using eCommerce.Models.Exercises.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Models.Exercises.EntitiesConfiguration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> user)
    {
        user.ToTable("Users");
        user.HasKey(u => u.Id);
        user.Property(u => u.Name).HasMaxLength(30).IsRequired();
        user.Property(u => u.Email).HasMaxLength(100).IsRequired();
        user.Property(u => u.Sex).IsRequired();
        user.Property(u  => u.Rg).HasColumnName("General_register").IsRequired();
        user.HasIndex(u => u.Cpf).IsUnique().HasFilter("[CPF] IS NOT NULL]");
        user.Property(u => u.MotherName).HasMaxLength(30).IsRequired();
        user.Property(u => u.FatherName).HasMaxLength(30).IsRequired();
        user.Property(u => u.RegistrationStatus).HasColumnType("date");
        user.Property(u => u.RegistrationDate).HasColumnType("date");

        // 1:1
        user.HasOne<Contact>(u => u.Contact).WithOne(c => c.User)
            .HasForeignKey<Contact>(c => c.UserId);
        
        // 1:M
        user.HasMany<DeliveryAddress>(u => u.DeliveryAddresses)
            .WithOne(d => d.User);
        
        // M:M
        user.HasMany<ProductDepartment>(u => u.ProductDepartments)
            .WithMany(p => p.Users);
    }
}