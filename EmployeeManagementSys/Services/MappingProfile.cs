using AutoMapper;
using EmployeeManagementSys.DTOs;
using EmployeeManagementSys.Models;

namespace EmployeeManagementSys.Services
{
    public class MappingProfile : Profile
    {

        public MappingProfile() 
        { 
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
        }
    }
}
