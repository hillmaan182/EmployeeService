using AutoMapper;
using EmployeeService.Models;
using EmployeeService.DTO;
namespace EmployeeService
{
    public class AppMapperProfile : Profile
    {
        public AppMapperProfile()
        {
            CreateMap<EmployeeAddressDTO, EmployeeAddress>();
            CreateMap<EmployeeDTO, Employee>();
            CreateMap<ProjectDTO, Project>();
        }
    }

}