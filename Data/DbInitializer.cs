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
            new Employee{FirstMidName="Carson",LastName="Alexander",TypeDoc=TypeDoc.DUI,Document="03333445-7",AreaName="Operations"},
            new Employee{FirstMidName="Meredith",LastName="Alonso",TypeDoc=TypeDoc.DUI,Document="03333445-8",AreaName="Information Services"},
            new Employee{FirstMidName="Arturo",LastName="Anand",TypeDoc=TypeDoc.NIT,Document="0614-171089-145-1",AreaName="Human Resources"},
            new Employee{FirstMidName="Gytis",LastName="Barzdukas",TypeDoc=TypeDoc.NIT,Document="0614-171089-145-1",AreaName="Human Resources"},
            new Employee{FirstMidName="Yan",LastName="Li",TypeDoc=TypeDoc.DUI,Document="0614-171089-3",AreaName="Marketing"},
            new Employee{FirstMidName="Peggy",LastName="Justice",TypeDoc=TypeDoc.Passport,Document="0614-171089-6",AreaName="Human Resources"},
            new Employee{FirstMidName="Javier",LastName="Romero",TypeDoc=TypeDoc.DUI,Document="06171089-1",AreaName="Information Services"},
            new Employee{FirstMidName="Will",LastName="Smith",TypeDoc=TypeDoc.Passport,Document="0614-171089-1",AreaName="Information Technologies"},
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