using eCommerce.Models.Exercises.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Models.Exercises.EntitiesConfiguration;

public class ProductDepartamentConfiguration : IEntityTypeConfiguration<ProductDepartment>
{
    public void Configure(EntityTypeBuilder<ProductDepartment> productDepartment)
    {
        productDepartment.ToTable("ProductDepartments");
        productDepartment.HasKey(p => p.Id);
        productDepartment.Property(p => p.Name).HasMaxLength(100).IsRequired();

        productDepartment.HasMany<User>(u => u.Users)
            .WithMany(u => u.ProductDepartments);
    }
}