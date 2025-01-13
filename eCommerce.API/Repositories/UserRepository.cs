using eCommerce.Models.Models;

namespace eCommerce.API.Repositories;

public class UserRepository : IUserRepository
{
    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<User?> GetUserByIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task AddUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteUserAsync(int userId)
    {
        throw new NotImplementedException();
    }
}