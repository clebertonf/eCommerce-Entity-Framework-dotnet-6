namespace eCommerceConsole.Office.Models;

public class EmployeeVehicle
{
    // MER
    public int EmployeeId { get; set; }
    public int VehicleId { get; set; }
    
    public DateTimeOffset VehicleStartDate { get; set; }
    
    // POO
    public Employee Employee { get; set; }
    public Vehicle Vehicle { get; set; }
}