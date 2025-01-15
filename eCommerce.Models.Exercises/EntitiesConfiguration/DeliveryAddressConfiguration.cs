using eCommerce.Models.Exercises.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Models.Exercises.EntitiesConfiguration;

public class DeliveryAddressConfiguration : IEntityTypeConfiguration<DeliveryAddress>
{
    public void Configure(EntityTypeBuilder<DeliveryAddress> deliveryAddress)
    {
        deliveryAddress.ToTable("DeliveryAddress");
        deliveryAddress.HasKey(d => d.Id);
        deliveryAddress.Property(d => d.AddressName).HasMaxLength(50).IsRequired();
        deliveryAddress.Property(d => d.ZipCode).HasMaxLength(50).IsRequired();
        deliveryAddress.Property(d => d.State).HasMaxLength(50).IsRequired();
        deliveryAddress.Property(d => d.City).HasMaxLength(50).IsRequired();
        deliveryAddress.Property(d => d.Neighborhood).HasMaxLength(50).IsRequired();
        deliveryAddress.Property(d => d.Address).HasMaxLength(50).IsRequired();
        deliveryAddress.Property(d => d.AddressNumber).HasMaxLength(50).IsRequired();
        deliveryAddress.Property(d => d.Complement).HasMaxLength(50).IsRequired();
        
        deliveryAddress.HasOne<User>(u => u.User)
            .WithMany(u => u.DeliveryAddresses);
    }
}