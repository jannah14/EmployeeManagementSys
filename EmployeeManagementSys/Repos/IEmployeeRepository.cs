using EmployeeManagementSys.Models;

namespace EmployeeManagementSys.Repos
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>?> GetEmployees(); //return data for all the employees in the database

        Task<Employee?> GetEmployeeById(string employeeId); //return data for one employee based on Id

        Task<bool> DeleteEmployee(string employeeId);
        Task<bool> UpdateEmployee(Employee user);

        Task<bool> CreateEmployee(Employee user);
    }
}
