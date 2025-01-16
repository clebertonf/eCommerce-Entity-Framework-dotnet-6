
using eCommerceConsole.Office.Context;
using eCommerceConsole.Office.Models;
using Microsoft.EntityFrameworkCore;

using var db = new EcommerceOfficeContext();

#region EFcore < 3.1
var result = db.Sectors.Include(c => c.EmployeeSectors).ThenInclude(c => c.Employee);

foreach (var sector in result)
{
    foreach (var employee in sector.EmployeeSectors)
    {
        Console.WriteLine($"Employee => {employee.Employee.Name} \n => Sector - {sector.Name}");
        Console.WriteLine("===========");
    }
}
Console.WriteLine("Done. EFcore < 3.1");
Console.WriteLine("------------------");
#endregion

#region EFcore > 5.0
var resultClass = db.Employees.Include(e => e.EmployeeClasses);
foreach (var employee in resultClass)
{
    foreach (var employeeClass in employee.EmployeeClasses)
    {
        Console.WriteLine($"Empoyee => {employee.Name} \n => Class - {employeeClass.Name}");
    }
}
Console.WriteLine("Done. EFcore > 5.0");
Console.WriteLine("------------------");
#endregion

#region EFcore > 5.0 + payload
var employeeVehiche = db.Employees.Include(e => e.EmployeeVehicles).ThenInclude(e => e.Vehicle);
foreach (var employee in employeeVehiche)
{
    Console.WriteLine($"Name => {employee.Name}");
    foreach (var vehicle in employee.EmployeeVehicles)
    {
        Console.WriteLine($"-- Vehicle => {vehicle.Vehicle.Name}({vehicle.Vehicle.Plate}) Date => {vehicle.VehicleStartDate}");
    }
}

Console.WriteLine("EFcore > 5.0 + payload");
Console.WriteLine("------------------");

// If it doesn't map in the context, you can access it like this
var employeesVehicle = db.Set<EmployeeVehicle>().SingleOrDefault(v => v.EmployeeId == 1 && v.VehicleId == 1);
Console.WriteLine(employeesVehicle.VehicleStartDate);
#endregion
