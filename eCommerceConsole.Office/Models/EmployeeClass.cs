﻿namespace eCommerceConsole.Office.Models;

public class EmployeeClass
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<Employee>? Employees { get; set; }
}