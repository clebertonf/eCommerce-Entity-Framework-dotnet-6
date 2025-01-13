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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductDepartment>().HasData(
            new ProductDepartment() { Id = 1, Name = "Electronics" },
            new ProductDepartment() { Id = 2, Name = "Fashion" },
            new ProductDepartment() { Id = 3, Name = "Home and Kitchen" },
            new ProductDepartment() { Id = 4, Name = "Sports and Outdoors" },
            new ProductDepartment() { Id = 5, Name = "Health and Beauty" },
            new ProductDepartment() { Id = 6, Name = "Toys and Games" },
            new ProductDepartment() { Id = 7, Name = "Books" },
            new ProductDepartment() { Id = 8, Name = "Automotive" },
            new ProductDepartment() { Id = 9, Name = "Groceries" },
            new ProductDepartment() { Id = 10, Name = "Pet Supplies" },
            new ProductDepartment() { Id = 11, Name = "Office Supplies" },
            new ProductDepartment() { Id = 12, Name = "Baby Products" }
        );
    }
}