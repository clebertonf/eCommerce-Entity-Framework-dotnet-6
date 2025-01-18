using eCommerce.Console.OtherResources.Models;
using Microsoft.EntityFrameworkCore;
namespace eCommerce.Console.OtherResources;

public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=eCommerce;User Id=sa;Password=senhaEstudo123;TrustServerCertificate=True");
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
    public DbSet<ProductDepartment> ProductDepartments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<User>().HasQueryFilter(u => u.RegistrationDate.Day >= 15 && u.RegistrationDate.Day <= 17); // Global filter that applies the rule to all queries
        // modelBuilder.Entity<User>().HasQueryFilter(u => u.RegistrationStatus == RegistrationStatus.Active); // Global filter that applies the rule to all queries
         modelBuilder.Entity<User>().Property(u => u.RegistrationStatus).HasConversion<string>(); // Converters Emun for string
        
        // Active Temporal tables with configs (Temporal tables Exclusive Sql server or sql azure EF core > 6)
        modelBuilder.Entity<User>().ToTable("Users", u => u.IsTemporal(
            t =>
            {
                t.UseHistoryTable("UserHistory");
                t.HasPeriodStart("InitialPeriod");
                t.HasPeriodEnd("FinalPeriod");
            }));
    }
}