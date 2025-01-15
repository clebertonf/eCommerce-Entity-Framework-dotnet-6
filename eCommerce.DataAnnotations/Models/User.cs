using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ECommerce.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.DataAnnotations.Models;

[Index(nameof(Email), IsUnique = true, Name = "UNIQUE_EMAIL")]
[Index(nameof(Cpf), IsUnique = true, Name = "UNIQUE_CPF")]
[Index(nameof(Name), nameof(Sex))]
[Table("TB_USERS")]
public class
    User
{
    // [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Key] public int Id { get; set; }
    [Column("FIRST_NAME")] public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    [Required]
    [MaxLength(10)]
    public string? Sex { get; set; }
    public string? Rg { get; set; }
    public string Cpf { get; set; } = null!;
    [MaxLength(50)]
    public string? MotherName { get; set; }
    [MaxLength(50)]
    public string? FatherName { get; set; }
    public string? RegistrationStatus { get; set; }
    [NotMapped] public bool IsActive { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Enrolment { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTimeOffset RegistrationDate { get; set; }

    public Contact? Contact { get; set; }
    public ICollection<DeliveryAddress>? DeliveryAddresses { get; set; }
    public ICollection<ProductDepartment>? ProductDepartments { get; set; }
    
    [InverseProperty("Client")]
    public ICollection<Order>? CustomerRequests { get; set; }
    
    [InverseProperty("Employee")]
    public ICollection<Order>? EmployeeManagedOrders { get; set; }
    
    [InverseProperty("Supervisor")]
    public ICollection<Order>? SupervisorManagedOrders  { get; set; }
}