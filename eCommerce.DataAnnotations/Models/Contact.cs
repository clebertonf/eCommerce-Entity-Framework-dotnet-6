using System.ComponentModel.DataAnnotations.Schema;
using ECommerce.Models.Models;

namespace eCommerce.DataAnnotations.Models;

public class Contact
{
    public int Id { get; set; }
    public string? Phone { get; set; }
    public string? CellPhone { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User? User { get; set; }
}