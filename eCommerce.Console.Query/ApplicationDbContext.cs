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
        optionsBuilder.UseSqlServer( // UseLazyLoadingProxies() for lazyloading with proxies
            "Server=localhost,1433;Database=eCommerce;User Id=sa;Password=senhaEstudo123;TrustServerCertificate=True"); 
        // options => options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)); Enables split query behavior for the entire project
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().Navigation(u => u.Contact).AutoInclude();
    }
}