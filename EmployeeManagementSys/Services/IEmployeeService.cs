using EmployeeManagementSys.DTOs;
using EmployeeManagementSys.Models;

namespace EmployeeManagementSys.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDTO>?> GetEmployees(); //return data for all the employees in the database

        Task<EmployeeDTO?> GetEmployeeById(string employeeId); //return data for one employee based on Id

        Task<bool> DeleteEmployee(string employeeId);
        Task<bool> UpdateEmployee(Employee user);

        Task<bool> CreateEmployee(Employee user);
    }
}
