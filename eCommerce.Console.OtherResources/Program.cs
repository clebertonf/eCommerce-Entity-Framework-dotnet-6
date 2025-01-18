using Dapper;
using eCommerce.Console.OtherResources;
using eCommerce.Console.OtherResources.Models;
using Microsoft.EntityFrameworkCore;

var db = new ApplicationDbContext();

Console.WriteLine("=================================================");
// Global Filters
var usersWithGlobalFilter = db.Users.ToList(); // For ignore IgnoreQueryFilters()
foreach (var user in usersWithGlobalFilter)
{
    Console.WriteLine($"{user.Id} - {user.Name} {user.RegistrationDate}");
}

Console.WriteLine("=================================================");
// Value Conversion
db.ChangeTracker.Clear();
var users = db.Users.ToList();
foreach (var user in users)
{
    Console.WriteLine($"users {user.Id} - {user.Name} {user.RegistrationStatus}");
}

Console.WriteLine("=================================================");
// Temporal tables Exclusive Sql server or sql azure EF core > 6
// TemporalAll()
var userTempTemporalAll = db.Users.TemporalAll().Where(u => u.Id == 1).OrderBy(u => EF.Property<DateTime>(u, "InitialPeriod"));
foreach (var user in userTempTemporalAll)
{
    Console.WriteLine($"userTempTemporalAll {user.Id} - {user.Name} {user.Email}");
}

// TemporalAsOf()
var date = new DateTime(2025, 1, 17, 22, 22, 00);
var userTempTemporAsOf = db.Users.TemporalAsOf(date).Where(u => u.Id == 1).OrderBy(u => EF.Property<DateTime>(u, "InitialPeriod"));
foreach (var user in userTempTemporAsOf)
{
    Console.WriteLine($"userTempTemporAsOf {user.Id} - {user.Name} {user.Email}");
}

// TemporalFromTo() TemporalBetween()
var start = new DateTime(2025, 1, 17, 22, 22, 00);
var end = new DateTime(2025, 1, 17, 22, 22, 00);
var userTemporalFromTo = db.Users.TemporalFromTo(start, end).Where(u => u.Id == 1).OrderBy(u => EF.Property<DateTime>(u, "InitialPeriod"));
foreach (var user in userTemporalFromTo)
{
    Console.WriteLine($"userTemporalFromTo {user.Id} - {user.Name} {user.Email}");
}

// TemporalContainedIn()
var startTwo = new DateTime(2025, 1, 17, 22, 22, 00);
var endTwo = new DateTime(2025, 1, 17, 22, 22, 00);
var userTemporalContainedIn = db.Users.TemporalContainedIn(startTwo, endTwo).Where(u => u.Id == 1).OrderBy(u => EF.Property<DateTime>(u, "InitialPeriod"));
foreach (var user in userTemporalContainedIn)
{
    Console.WriteLine($"userTemporalContainedIn {user.Id} - {user.Name} {user.Email}");
}

Console.WriteLine("=================================================");
// Integration with Dapper

var connection = db.Database.GetDbConnection();
var usersWithDapper = connection.Query<User>("SELECT * FROM [Users]");
foreach (var user in usersWithDapper)
{
    Console.WriteLine($"usersWithDapper {user.Id} - {user.Name} {user.RegistrationDate}");
}