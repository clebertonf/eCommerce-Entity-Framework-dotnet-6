using eCommerce.Console.Tracking.Models;

namespace eCommerce.Models.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; }  = null!;
    public string? Sex { get; set; }
    public string? Rg { get; set; }
    public string Cpf { get; set; }  = null!;
    public string? MotherName { get; set; }
    public string? FatherName { get; set; }
    public string? RegistrationStatus { get; set; }
    public DateTimeOffset RegistrationDate { get; set; }
    public Contact? Contact { get; set; }
    public ICollection<DeliveryAddress>? DeliveryAddresses { get; set; }
    public ICollection<ProductDepartment>? ProductDepartments { get; set; }
}