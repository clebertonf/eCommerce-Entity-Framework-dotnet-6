using ECommerce.Models.Models;

namespace eCommerce.DataAnnotations.Models;

public class ProductDepartment
{
    public int Id { get; set; }
    public string Name { get; set; }  = null!;
    public ICollection<User>? Users { get; set; }
}