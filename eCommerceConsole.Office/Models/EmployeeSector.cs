namespace eCommerceConsole.Office.Models;

public class EmployeeSector
{
    public int EmployeeId { get; set; }
    public int SectorId { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public Employee? Employee { get; set; }
    public Sector? Sector { get; set; }
}