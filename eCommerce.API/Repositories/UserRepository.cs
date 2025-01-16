using eCommerce.API.Context;
using eCommerce.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await _context.Users.Include(u => u.Contact).ToListAsync();
    }

    public async Task<User?> GetUserByIdAsync(int userId)
    {
        return await _context.Users
            .Include(u => u.Contact)
            .Include(u => u.DeliveryAddresses)
            .Include(u => u.ProductDepartments)
            .FirstOrDefaultAsync(u => u.Id == userId);
    }

    public async Task AddUserAsync(User user)
    {
        if (user.ProductDepartments is not null)
        {
            var departaments = user.ProductDepartments;
            
            user.ProductDepartments = new List<ProductDepartment>();
            
            foreach (var department in departaments)
            {
                if (department.Id > 0)
                {
                    user.ProductDepartments.Add(_context.ProductDepartments.Find(department.Id));
                }
                else
                {
                    user.ProductDepartments.Add(department);
                }
            }
        }
        
        await _context.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteUserAsync(int userId)
    {
        var user = await GetUserByIdAsync(userId);
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }
}