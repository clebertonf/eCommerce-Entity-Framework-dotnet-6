// See https://aka.ms/new-console-template for more information

using eCommerce.Console.Tracking;
using Microsoft.EntityFrameworkCore;

var db = new ApplicationDbContext();

var user = db.Users.FirstOrDefault(u => u.Id == 1);
user.Name = "John Doe";
db.SaveChanges();

// No tracking object
var user2 = db.Users.AsNoTracking().FirstOrDefault(u => u.Id == 1);
user2.Name = "John Doe";
db.Update(user2);
db.SaveChanges();

// It clears up the content and is no longer accompanied by the EFcore
db.ChangeTracker.Clear();