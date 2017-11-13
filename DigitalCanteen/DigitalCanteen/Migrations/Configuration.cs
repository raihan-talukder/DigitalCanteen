using DigitalCanteen.Models.Entities;

namespace DigitalCanteen.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DigitalCanteen.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DigitalCanteen.Data.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var userCredential = new UserCredential()
            {
                Username = "Admin",
                Password = "Admin",
                UserType = 1
            };

            var userDetail = new UserDetail()
            {
                FullName = "Mr. Admin",
                Department = "Cse",
                Email = "admin@admin.com",
                Phone = "136846341",
                DateOfBirth = DateTime.Now,
              
                Address = "fdsfsdfdsf",
            
                UserCredential = userCredential

            };



            context.UserDetails.AddOrUpdate(userDetail);
        }
    }
}
