using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.SeedData;

public static  class SeedData
{
    public static void Seed(DataContext context)
    {
      
        
       

        var employees = new List<Employee>()
        {
            new (1, "Ardahser", "Sattorzoda", "ardasher@gmail.com", "881933339", 2000, 1, 1, DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)),
            new (2, "Abdullah", "Sheralizoda", "abdullah@gmail.com", "881933339", 2500, 2, 2, DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)),
            new (3, "Anushervon", "Bekov", "anushervon@gmail.com", "881933339", 3000, 3, 3, DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc) ),
            new (4, "Sherzod", "Ishankulov", "sherzod@gmail.com", "881933339", 3500, 4, 4, DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)),
            new (5, "Muhammad", "Yaqubzoda", "muhammad@gmail.com", "881933339", 4000, 5, 5, DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc) ),
        };

        var jobs = new List<Job>()
        {
            new (1, "Back-End Developer", 2000, 5000),
            new (2, "C# Developer", 2500, 5500),
            new (3, "Front-End Developer", 3000, 6000),
            new (4, "C++ Developer", 3500, 6500),
            new (5, "Html/css Developer", 4000, 7000),

        };
        var employeedepatments = new List<EmployeeDepartment>()
        {
            new (1,1, DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)),
            new (2,2, DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)),
            new (3,3, DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)),
            new (4,4, DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)),
            new (5,5, DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)),
        };

        var departments = new List<Department>()
        {
            new (1, "Softclub", 1, 1),
            new (2, "Alif", 2, 2),
            new (3, "Humo", 3, 3),
            new (4, "Megafon", 4, 4),
            new (5, "Babilon", 5, 5),
        };

      var locations = new List<Location>()
      {
            new (1, "AlisherNavoi", "Dushanbe", "Idk", "01", 1),
            new (2, "Makhsum", "Asht", "Idk", "02", 2),
            new (3, "Rudaki", "Kulob", "Idk", "03", 3),
            new (4, "Sino", "Dushanbe", "Idk", "01", 4),
            new (5, "Sino2", "Farkhor", "Idk", "03", 5),
      };

      var countries = new List<Country>()
      {
            new (1, "Tajikistan", 1),
            new (2, "Russia", 2),
            new (3, "Sweden", 2),
            new (4, "Canada", 4),
            new (5, "Australia", 5),
      };

      var regions = new List<Region>()
      {
            new (1, "Asia"),
            new (2, "Europe"),
            new (3, "North America"),
            new (4, "Oceania"),
      };

      context.Employees.AddRange(employees);
      context.Jobs.AddRange(jobs);
      context.EmployeeDepartments.AddRange(employeedepatments);
      context.Departments.AddRange(departments);
      context.Locations.AddRange(locations);
      context.Countries.AddRange(countries);
      context.Regions.AddRange(regions);
      context.SaveChanges();
      
    }

    
}