namespace eCommerce.Models.Models;

public class DeliveryAddress
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string? AddressName { get; set; }
    public string? ZipCode { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }
    public string? Neighborhood { get; set; }
    public string? Address { get; set; }
    public string? AddressNumber { get; set; }
    public string? Complement { get; set; } 
    public User? User { get; set; }
}