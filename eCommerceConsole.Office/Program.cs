
using eCommerceConsole.Office.Context;
using Microsoft.EntityFrameworkCore;

using var db = new EcommerceOfficeContext();
var result = db.Sectors.Include(c => c.EmployeeSectors).ThenInclude(c => c.Employee);

foreach (var sector in result)
{
    foreach (var employee in sector.EmployeeSectors)
    {
        Console.WriteLine($"Employee => {employee.Employee.Name} \n => Sector - {sector.Name}");
        Console.WriteLine("===========");
    }
}