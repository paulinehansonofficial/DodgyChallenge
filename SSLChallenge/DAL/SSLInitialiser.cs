using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SSLChallenge.Models;

namespace SSLChallenge.DAL
{
    public class SSLInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<SSLContext>
    {
        protected override void Seed(SSLContext context)
        {
            var users = new List<User>
            {
                new User{userID="s1404326303", firstName="Kandace", lastName="Wyett"},
                new User{userID="s1404326304", firstName="Kelby", lastName="Grayshan"},
                new User{userID="s1404326305", firstName="Lula", lastName="Darnborough"},
                new User{userID="s1404326306", firstName="Nerti", lastName="Steely"},
                new User{userID="s1404326307", firstName="Christabel", lastName="Stairs"}
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var modules = new List<Module>
            {
                new Module{macAddressID="4B-9C-6D-09-C0-C3", issuedDate=DateTime.Parse("2017-01-11"), studentResponsible="s1404326303"},
                new Module{macAddressID="76-37-47-F0-2D-98", issuedDate=DateTime.Parse("2017-02-09"), studentResponsible="s1404326304"},
                new Module{macAddressID="5B-9D-7D-08-C0-F6", issuedDate=DateTime.Parse("2017-03-10"), studentResponsible="s1404326305"},
                new Module{macAddressID="7B-8C-2D-06-C1-C9", issuedDate=DateTime.Parse("2017-04-11"), studentResponsible="s1404326306"},
                new Module{macAddressID="4A-9D-2D-07-C8-A3", issuedDate=DateTime.Parse("2017-05-12"), studentResponsible="s1404326307"}
            };

            modules.ForEach(m => context.Modules.Add(m));
            context.SaveChanges();
        }
    }
}