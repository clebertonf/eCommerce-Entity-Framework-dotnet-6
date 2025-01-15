using System.ComponentModel.DataAnnotations.Schema;
using ECommerce.Models.Models;

namespace eCommerce.DataAnnotations.Models;

public class Order
{
    public int Id { get; set; }
    
    [ForeignKey("Client")]
    public int ClientId { get; set; }
    
    [ForeignKey("Employee")]
    public int EmployeeId { get; set; }
    
    [ForeignKey("Supervisor")]
    public int SupervisorId { get; set; }

    public User? Client { get; set; }
    public User? Employee { get; set; }
    public User? Supervisor { get; set; }
}