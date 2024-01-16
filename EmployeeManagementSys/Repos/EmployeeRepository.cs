using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSys.Data;
using EmployeeManagementSys.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSys.Repos
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateEmployee(Employee employee)
        {
            try
            {
                _dbContext.Employees.Add(employee);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred");
                return false;
            }
        }

        public async Task<bool> DeleteEmployee(string userId)
        {
            try
            {
                var employee = await _dbContext.Employees.FindAsync(userId);
                if (employee != null)
                {
                    _dbContext.Employees.Remove(employee);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred");
                return false;
            }
        }

        public async Task<List<Employee>?> GetEmployees()
        {
            try
            {
                return await _dbContext.Employees.ToListAsync();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred");
                return null;
            }
        }

        public ApplicationDbContext Get_dbContext()
        {
            return _dbContext;
        }

        public async Task<Employee?> GetEmployeeById(string userId, ApplicationDbContext _dbContext)
        {
            try
            {
                return await _dbContext.Employees.FindAsync(userId);
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred");
                return null;
            }
        }

        public async Task<bool> UpdateEmployee(Employee employee)
        {
            try
            {
                _dbContext.Entry(employee).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred");
                return false;
            }
        }
    }
}
