using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagementSys.DTOs;
using EmployeeManagementSys.Models;
using EmployeeManagementSys.Repos;

namespace EmployeeManagementSys.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                var employee = _mapper.Map<Employee>(employeeDTO);
                return await _employeeRepository.CreateEmployee(employee);
            }
            catch (Exception)
            {
                // Handle exception, log, etc.
                return false;
            }
        }

        public async Task<bool> DeleteEmployee(string employeeId)
        {
            try
            {
                return await _employeeRepository.DeleteEmployee(employeeId);
            }
            catch (Exception)
            {
                // Handle exception, log, etc.
                return false;
            }
        }

        public async Task<EmployeeDTO?> GetEmployeeById(string employeeId)
        {
            try
            {
                var employee = await _employeeRepository.GetEmployeeById(employeeId);
                return _mapper.Map<EmployeeDTO>(employee);
            }
            catch (Exception)
            {
                // Handle exception, log, etc.
                return null;
            }
        }

        public async Task<List<EmployeeDTO>?> GetEmployees()
        {
            try
            {
                var employees = await _employeeRepository.GetEmployees();
                return _mapper.Map<List<EmployeeDTO>>(employees);
            }
            catch (Exception)
            {
                // Handle exception, log, etc.
                return null;
            }
        }

        public async Task<bool> UpdateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                var employee = _mapper.Map<Employee>(employeeDTO);
                return await _employeeRepository.UpdateEmployee(employee);
            }
            catch (Exception)
            {
                // Handle exception, log, etc.
                return false;
            }
        }
    }
}
