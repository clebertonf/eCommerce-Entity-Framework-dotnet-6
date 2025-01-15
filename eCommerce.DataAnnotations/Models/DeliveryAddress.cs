using eCommerce.DataAnnotations.Models;

namespace ECommerce.Models.Models;

public class DeliveryAddress
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string? AddressName { get; set; }  = null!;
    public string? ZipCode { get; set; }  = null!;
    public string? State { get; set; }  = null!;
    public string? City { get; set; }  = null!;
    public string? Neighborhood { get; set; }  = null!;
    public string? Address { get; set; }  = null!;
    public string? AddressNumber { get; set; }  = null!;
    public string? Complement { get; set; } 
    public User? User { get; set; }
}