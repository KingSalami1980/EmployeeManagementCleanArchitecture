using AutoMapper;
using Employee.Application.Commands;
using Employee.Application.Responses;

namespace Employee.Application.Mappers
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Core.Entities.Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Core.Entities.Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}
