using eCommerce.Models.Models;

namespace eCommerce.Console.Tracking.Models;

public class ProductDepartment
{
    public int Id { get; set; }
    public string Name { get; set; }  = null!;
    public ICollection<User>? Users { get; set; }
}