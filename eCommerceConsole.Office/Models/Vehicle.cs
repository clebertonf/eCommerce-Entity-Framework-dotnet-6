namespace eCommerceConsole.Office.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Plate { get; set; } = null!;
    public int EmployeeId { get; set; }
    public ICollection<Employee>? Employees { get; set; }
    public ICollection<EmployeeVehicle>? EmployeeVehicles { get; set; }
}