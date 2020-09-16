using OneLinkCompany.Models;
using System;
using System.Linq;

namespace OneLinkCompany.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CompanyContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
            new Employee{FirstMidName="Carson",LastName="Alexander"},
            new Employee{FirstMidName="Meredith",LastName="Alonso"},
            new Employee{FirstMidName="Arturo",LastName="Anand"},
            new Employee{FirstMidName="Gytis",LastName="Barzdukas"},
            new Employee{FirstMidName="Yan",LastName="Li"},
            new Employee{FirstMidName="Peggy",LastName="Justice"},
            new Employee{FirstMidName="Javier",LastName="Romero"},
            new Employee{FirstMidName="Will",LastName="Smith"},
            };
            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();

            var subareas = new Subarea[]
            {
            new Subarea{SubareaID=1050,Name="Networking"},
            new Subarea{SubareaID=4022,Name="Human Resources"},
            new Subarea{SubareaID=1045,Name="Sales"},
            new Subarea{SubareaID=3141,Name="Marketing Strategies"}
            };
            foreach (Subarea s in subareas)
            {
                context.Subareas.Add(s);
            }
            context.SaveChanges();

            var areas = new Area[]
            {
            new Area{EmployeeID=1,SubareaID=1050,Name="IT"},
            new Area{EmployeeID=1,SubareaID=4022,Name="Admin"},
            new Area{EmployeeID=2,SubareaID=1045,Name="Operations"},
            new Area{EmployeeID=2,SubareaID=3141,Name="Marketing"}
            };
            foreach (Area a in areas)
            {
                context.Areas.Add(a);
            }
            context.SaveChanges();
        }
    }
}