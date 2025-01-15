using eCommerceConsole.Office.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceConsole.Office.Context;

public class EcommerceOfficeContext: DbContext
{
   // public EcommerceOfficeContext(DbContextOptions<EcommerceOfficeContext> options) : base(options) { }
    
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeClass> EmployeeClasses { get; set; }
    public DbSet<Sector> Sectors { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<EmployeeSector> EmployeeSectors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=eCommerceOffice;User Id=sa;Password=senhaEstudo123;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*
         * Many to Many EFcore < 5 with intermediate table
         */
        
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Employee>()
            .HasMany<EmployeeSector>(e => e.EmployeeSectors)
            .WithOne(e => e.Employee)
            .HasForeignKey(c => c.EmployeeId);
        
        modelBuilder.Entity<Sector>()
            .HasMany(s => s.EmployeeSectors)
            .WithOne(s => s.Sector)
            .HasForeignKey(s => s.SectorId);
        
        modelBuilder.Entity<EmployeeSector>()
            .HasKey(e => new { e.EmployeeId, e.SectorId });

        #region Seeds

        modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, Name = "John Doe" },
            new Employee { Id = 2, Name = "Jane Smith" },
            new Employee { Id = 3, Name = "Michael Johnson" },
            new Employee { Id = 4, Name = "Emily Davis" },
            new Employee { Id = 5, Name = "William Brown" },
            new Employee { Id = 6, Name = "Sophia Wilson" },
            new Employee { Id = 7, Name = "James Anderson" },
            new Employee { Id = 8, Name = "Olivia Martinez" },
            new Employee { Id = 9, Name = "Alexander Garcia" },
            new Employee { Id = 10, Name = "Emma Thomas" }
            );

        modelBuilder.Entity<Sector>().HasData(
            new Sector { Id = 1, Name = "Human Resources" },
            new Sector { Id = 2, Name = "Finance" },
            new Sector { Id = 3, Name = "Marketing" },
            new Sector { Id = 4, Name = "Sales" },
            new Sector { Id = 5, Name = "IT Support" },
            new Sector { Id = 6, Name = "Research and Development" },
            new Sector { Id = 7, Name = "Customer Service" },
            new Sector { Id = 8, Name = "Logistics" },
            new Sector { Id = 9, Name = "Operations" },
            new Sector { Id = 10, Name = "Legal" }
        );

        modelBuilder.Entity<EmployeeSector>().HasData(
            new EmployeeSector { EmployeeId = 1, SectorId = 10, CreatedAt = DateTime.Now },
            new EmployeeSector { EmployeeId = 2, SectorId = 9, CreatedAt = DateTime.Now },
            new EmployeeSector { EmployeeId = 3, SectorId = 8, CreatedAt = DateTime.Now },
            new EmployeeSector { EmployeeId = 4, SectorId = 7, CreatedAt = DateTime.Now },
            new EmployeeSector { EmployeeId = 5, SectorId = 6, CreatedAt = DateTime.Now },
            new EmployeeSector { EmployeeId = 6, SectorId = 5, CreatedAt = DateTime.Now },
            new EmployeeSector { EmployeeId = 7, SectorId = 4, CreatedAt = DateTime.Now },
            new EmployeeSector { EmployeeId = 8, SectorId = 3, CreatedAt = DateTime.Now },
            new EmployeeSector { EmployeeId = 9, SectorId = 2, CreatedAt = DateTime.Now },
            new EmployeeSector { EmployeeId = 10, SectorId = 1, CreatedAt = DateTime.Now}
            );

        #endregion
    }
}