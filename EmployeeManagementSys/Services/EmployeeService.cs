using EmployeeManagementSys.DTOs;
using EmployeeManagementSys.Models;

namespace EmployeeManagementSys.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Task<bool> CreateEmployee(Employee user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEmployee(string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeDTO?> GetEmployeeById(string employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeDTO>?> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEmployee(Employee user)
        {
            throw new NotImplementedException();
        }
    }
}
