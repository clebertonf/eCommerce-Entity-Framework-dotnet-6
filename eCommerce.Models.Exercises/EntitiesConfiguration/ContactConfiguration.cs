using eCommerce.Models.Exercises.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerce.Models.Exercises.EntitiesConfiguration;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> contact)
    {
        contact.ToTable("Contacts");
        contact.HasKey(c => c.Id);
        contact.Property(c => c.Phone).HasMaxLength(20).IsRequired();
        contact.Property(c => c.CellPhone).HasMaxLength(20).IsRequired();

        contact.HasOne(c => c.User)
            .WithOne(u => u.Contact).HasForeignKey<Contact>(c => c.UserId);
    }
}