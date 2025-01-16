using eCommerce.Console.Tracking.Models;
using eCommerce.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace eCommerce.Console.Tracking;

public class ApplicationDbContext : DbContext
{
   // public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
    public DbSet<ProductDepartment> ProductDepartments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=eCommerceOffice;User Id=sa;Password=senhaEstudo123;TrustServerCertificate=True")
            .LogTo(System.Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging() // Enable logs EFcore
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking); // Deactivate Tracking
    }

}