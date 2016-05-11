namespace EmployeesRegister.Migrations
{
    using EmployeesRegister.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeesRegister.DataAccessLayer.EmployeesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeesRegister.DataAccessLayer.EmployeesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            context.Employees.AddOrUpdate(
               p => p.FirstName,
              new Employee {
                 
                  FirstName = "Andrew",
                  LastName = "Gustavsson",
                  Salary = 1000,
                  Position = "Apprentice",
                  Department = "R&D",
                  Company = "Acme Inc"
              },

              new Employee {
                 
                  FirstName = "Brice",
                  LastName = "Bruzon",
                  Salary = 2000,
                  Position = "Team Director",
                  Department = "Management"


              },
              new Employee {
             
                  FirstName = "Rowan",
                  LastName = "Rowanski",
                  Salary = 3000,
                  Position = "CEO",
                  Department = "Management"
             
              }
            
              
              
              
              );

        }
    }
}
