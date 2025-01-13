using eCommerce.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
    public DbSet<ProductDepartment> ProductDepartments { get; set; }
}