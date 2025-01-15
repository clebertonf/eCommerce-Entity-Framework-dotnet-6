namespace eCommerceConsole.Office.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<Vehicle>? Vehicles { get; set; }
    public ICollection<Sector>? Sectors { get; set; }
    public ICollection<EmployeeClass>? EmployeeClasses { get; set; }
}