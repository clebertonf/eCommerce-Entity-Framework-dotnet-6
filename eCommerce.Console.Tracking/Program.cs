// See https://aka.ms/new-console-template for more information

using eCommerce.Console.Tracking;
using eCommerce.Models.Models;
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

// Adds object to Efcore track
var user3 = new User() { Id = 1, Name = "John" };
db.Users.Attach(user3);
db.Entry(user3).Property(x => x.Name).IsModified = true;

// Console.WriteLine(db.ChangeTracker.DebugView.LongView); Debugging efcore tracing

// It clears up the content and is no longer accompanied by the EFcore
db.ChangeTracker.Clear();