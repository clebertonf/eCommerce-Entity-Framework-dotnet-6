using eCommerce.Models.Exercises.EntitiesConfiguration;
using eCommerce.Models.Exercises.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Models.Exercises;

public class EcommerceExerciesesContext : DbContext
{
    public EcommerceExerciesesContext(DbContextOptions<EcommerceExerciesesContext> options) : base(options){ }
    
    public DbSet<User>? Users { get; set; }
    public DbSet<Contact>? Contacts { get; set; }
    public DbSet<DeliveryAddress>? DeliveryAddresses { get; set; }
    public DbSet<ProductDepartment>? ProductDepartments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
       // modelBuilder.ApplyConfigurationsFromAssembly(typeof(EcommerceExerciesesContext).Assembly);
       modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}