using EmployeeManagementSys.Models;

namespace EmployeeManagementSys.Repos
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<bool> CreateEmployee(Employee user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEmployee(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetEmployee(string adminId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEmployee(Employee user)
        {
            throw new NotImplementedException();
        }
    }
}
