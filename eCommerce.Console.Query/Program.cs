using eCommerce.Console.Query;
using Microsoft.EntityFrameworkCore;

// First => LINQ EFcore SQL  After => .Tolist() -> C#

var db = new ApplicationDbContext();

// Tolist()
var users = db.Users.ToList();
Console.WriteLine("================= To List =======================");
foreach (var user in users)
{
    Console.WriteLine(user.Name);
}

Console.WriteLine("=================================================");
// Find(), First(), Last()
var userOneFind = db.Users!.Find(2); // string, object
Console.WriteLine($"Find => {userOneFind?.Name}");

var userTwoFirst = db.Users!.First();  // Exceptions happen if you don't find
Console.WriteLine($"First => {userTwoFirst?.Name}");

var  userTwoFirstOrDefault = db.Users!.FirstOrDefault(u => u.Id == 2); // Value or returns default value if you don't find
Console.WriteLine($"FirstOrDefault => {userTwoFirstOrDefault?.Name}");

Console.WriteLine("=================================================");
// Single(), Count(), Min(), Max()
var userThreeSingleOrDefault = db.Users.SingleOrDefault(u => u.Id == 3); // single()
Console.WriteLine($"SingleOrDefault => {userThreeSingleOrDefault?.Name}");

var countUsers = db.Users!.Count();
Console.WriteLine($"Count => {countUsers}");

var maxRegistrationDate = db.Users!.Max(u => u.RegistrationDate);
Console.WriteLine($"Max Registration Date => {maxRegistrationDate}");

var minId = db.Users!.Min(u => u.Id);
Console.WriteLine($"Min Id => {minId}");

Console.WriteLine("=================================================");
// Where()
var userWhere = db.Users.Where(u => u.Name == "Olivia Martinez" && u.Sex == "Female").ToList();
foreach (var user in userWhere)
{
    Console.WriteLine($"UserName => {user.Id} - {user.Name} - {user.Sex}");
}
// With Like (EF functions)
var userWhereEfFunctions = db.Users.Where( u => EF.Functions.Like(u.Name,"%s%")).ToList();
foreach (var user in userWhereEfFunctions)
{
    Console.WriteLine($"EfFunctions UserName => {user.Id} - {user.Name} - {user.Sex}");
}
// StartsWith
var userWhereStartsWith = db.Users.Where(u => u.Name.StartsWith("O")).ToList();
foreach (var user in userWhereStartsWith)
{
    Console.WriteLine($"StartsWith UserName => {user.Id} - {user.Name} - {user.Sex}");
}

// EndsWith
var userWhereEndsWith = db.Users.Where(u => u.Name.EndsWith("n")).ToList();
foreach (var user in userWhereEndsWith)
{
    Console.WriteLine($"EndsWith UserName => {user.Id} - {user.Name} - {user.Sex}");
}

// Contains
var userWhereContains = db.Users.Where(u => u.Name.Contains("a")).ToList();
foreach (var user in userWhereContains)
{
    Console.WriteLine($"Contains UserName => {user.Id} - {user.Name} - {user.Sex}");
}

Console.WriteLine("=================================================");
// OrderBy(), OrderByDescending(), ThenBy(), ThenByDescending()  

var usersOderBy = db.Users.OrderBy(u => u.Id).ToList();
foreach (var user in usersOderBy)
{
    Console.WriteLine($"OrderBy UserName => {user.Id} - {user.Name} - {user.Sex}");
}

// OrderByDescending()
var usersOrderByDescending = db.Users.OrderByDescending(u => u.Id).ToList();
foreach (var user in usersOrderByDescending)
{
    Console.WriteLine($"OrderByDescending UserName => {user.Id} - {user.Name} - {user.Sex}");
}

// ThenBy()
var usersOderByThenBy = db.Users.OrderBy(u => u.Sex).ThenBy(u => u.Id).ToList();
foreach (var user in usersOderByThenBy)
{
    Console.WriteLine($"OderByThenBy UserName => {user.Id} - {user.Name} - {user.Sex}");
}

// ThenByDescending() 
var usersOrderByDescendingThenByDescending = db.Users.OrderByDescending(u => u.Sex).ThenByDescending(u => u.Id).ToList();
foreach (var user in usersOrderByDescendingThenByDescending)
{
    Console.WriteLine($"OrderByDescendingThenByDescending UserName => {user.Id} - {user.Name} - {user.Sex}");
}

Console.WriteLine("=================================================");
// Eager Load
// Include(), ThenInclude(), AutoInclude()

var usersInclude = db.Users
    .Include(u => u.Contact)
    .Include(u => u.DeliveryAddresses).ToList();
foreach (var user in usersInclude)
{
    Console.WriteLine($"usersInclude UserName => {user.Id} - {user.Name} - {user.Sex} - Contact {user?.Contact?.CellPhone} - Qt Address: {user?.DeliveryAddresses?.Count}");
}

// ThenInclude() level thwo table

var contactsThenInclude = db.Contacts
    .Include(u => u.User)
    .ThenInclude(u => u.DeliveryAddresses).ToList();
foreach (var contact in contactsThenInclude)
{
    Console.WriteLine(
        $"contactsThenInclude => {contact.CellPhone} User: {contact?.User?.Name} QT Addres: {contact?.User?.DeliveryAddresses?.Count}");
}

// AutoInclude in ApplicationDbContext OnModelCreating
db.ChangeTracker.Clear(); // clean tracker
var usersAutoInclude = db.Users.ToList(); // IgnoreAutoIncludes() in specific places.

foreach (var user in usersAutoInclude)
{
    Console.WriteLine($"Users => {user.Id} - {user.Name} - {user.Contact?.CellPhone}");
}