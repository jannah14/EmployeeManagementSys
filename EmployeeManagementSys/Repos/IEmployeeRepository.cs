using EmployeeManagementSys.Models;

namespace EmployeeManagementSys.Repos
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployee(string adminId); //return data for all the employees in the database

        Task<Employee> GetEmployeeById(string userId); //return data for one employee based on Id

        Task<bool> DeleteEmployee(string userId);
        Task<bool> UpdateEmployee(Employee user);

        Task<bool> CreateEmployee(Employee user);
    }
}
