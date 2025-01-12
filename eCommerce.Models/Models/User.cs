namespace eCommerce.Models.Models;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Sex { get; set; }
    public string? Rg { get; set; }
    public string? Cpf { get; set; }
    public string? MotherName { get; set; }
    public string? RegistrationStatus { get; set; }
    public DateTimeOffset RegistrationDate { get; set; }
    public Contact? Contact { get; set; }
    public ICollection<DeliveryAddress>? DeliveryAddresses { get; set; }
    public ICollection<ProductDepartment>? ProductDepartments { get; set; }
}