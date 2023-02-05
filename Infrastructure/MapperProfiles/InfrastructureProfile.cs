using AutoMapper;
using Domain.Dtos;
using Domain.Entities;


namespace Infrastructure.MapperProfiles;

public class InfrastructureProfile : Profile
{
    public InfrastructureProfile()
    {
        CreateMap<EmployeeDto, Employee>();
        CreateMap<Employee, EmployeeDto>();
        CreateMap<EmployeeV2Dto, Employee>();
        CreateMap<Employee, EmployeeV2Dto>();
        CreateMap<Department, DepartmentDto>();
        CreateMap<DepartmentDto, Department>();
    }
}