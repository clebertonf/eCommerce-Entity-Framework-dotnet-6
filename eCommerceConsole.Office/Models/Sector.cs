namespace eCommerceConsole.Office.Models;

public class Sector
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<Employee>? Employees { get; set; }
}