using EmployeeManagementSys.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSys.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Other configurations...

            SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Employee>().HasData(
                new Employee { ID = Guid.NewGuid().ToString(), Name = "John Doe", Position = Position.Manager, Salary = 80000 },
                new Employee { ID = Guid.NewGuid().ToString(), Name = "Jane Ahmetaj", Position = Position.Developer, Salary = 70000 },
                new Employee { ID = Guid.NewGuid().ToString(), Name = "Ann Smith", Position = Position.CTO, Salary = 1000000 },
                new Employee { ID = Guid.NewGuid().ToString(), Name = "Bill Gates", Position = Position.CEO, Salary = 200000 },
                new Employee { ID = Guid.NewGuid().ToString(), Name = "Hannah Taylor", Position = Position.Developer, Salary = 100000 },
                new Employee { ID = Guid.NewGuid().ToString(), Name = "Noah Smith", Position = Position.Developer, Salary = 130000 },
                new Employee { ID = Guid.NewGuid().ToString(), Name = "Otis Wilson", Position = Position.HelpdeskSpecialist, Salary = 90000 },
                new Employee { ID = Guid.NewGuid().ToString(), Name = "Gary Gray", Position = Position.HR, Salary = 150000 },
                new Employee { ID = Guid.NewGuid().ToString(), Name = "Antonio Fisher", Position = Position.Manager, Salary = 300000 },
                new Employee { ID = Guid.NewGuid().ToString(), Name = "Sahair Ramadan", Position = Position.Developer, Salary = 90000 }
                
            );
        }

    }
}
