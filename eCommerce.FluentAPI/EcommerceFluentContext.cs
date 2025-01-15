using eCommerce.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.FluentAPI;

public class EcommerceFluentContext : DbContext
{
    public EcommerceFluentContext(DbContextOptions<EcommerceFluentContext> options) : base(options) { }
    
    public DbSet<User>? Users { get; set; }
    public DbSet<Contact>? Contacts { get; set; }
    public DbSet<DeliveryAddress>? DeliveryAddresses { get; set; }
    public DbSet<ProductDepartment>? ProductDepartments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("TB_USERS");
        modelBuilder.Entity<User>().Property(u => u.Rg).HasColumnName("GENERAL_REGISTER").HasMaxLength(10)
            .HasDefaultValue("NO_RG").IsRequired();
        modelBuilder.Entity<User>().Ignore(u => u.Sex);
        modelBuilder.Entity<User>().Property(u => u.Id).ValueGeneratedOnAdd();
        
        modelBuilder.Entity<User>().HasIndex(u => u.Cpf).IsUnique().HasFilter("[CPF] IS NOT NULL").HasDatabaseName("INDEX_USER_CPF");
        modelBuilder.Entity<User>().HasIndex(u => new { u.Name, u.Rg });

        modelBuilder.Entity<User>().HasKey(u => u.Id);
        // modelBuilder.Entity<User>().HasNoKey();
        modelBuilder.Entity<User>().HasAlternateKey(u => u.Email);
        
        // HasPrecision()
        
        // 1:1
        modelBuilder.Entity<User>().HasOne(u => u.Contact).WithOne(c => c.User).OnDelete(DeleteBehavior.Cascade); // .HasForeignKey<Contact>(c => c.UserId);
        // 1:M
        modelBuilder.Entity<User>().HasMany(u => u.DeliveryAddresses).WithOne(u => u.User).OnDelete(DeleteBehavior.ClientCascade); // .HasForeignKey(d => d.UserId);
        // M:M
        modelBuilder.Entity<User>().HasMany(u => u.ProductDepartments).WithMany(u => u.Users);
    }
}