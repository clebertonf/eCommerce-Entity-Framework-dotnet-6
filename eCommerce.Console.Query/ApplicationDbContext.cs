using eCommerce.Console.Query.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Console.Query;

public class ApplicationDbContext : DbContext
{
   // public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
    public DbSet<ProductDepartment> ProductDepartments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=eCommerce;User Id=sa;Password=senhaEstudo123;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().Navigation(u => u.Contact).AutoInclude();
    }
}