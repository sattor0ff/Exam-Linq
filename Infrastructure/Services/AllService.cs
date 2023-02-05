using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class AllService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public AllService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Response<List<EmployeeDepartmentDto>>> GetDepatrmentTime()
    {
        var list = await (from ed in _context.EmployeeDepartments
                          join e in _context.Employees on ed.EmployeeId equals e.Id
                          join d in _context.Departments on ed.DepartmentId equals d.Id
                    select new EmployeeDepartmentDto()
                    {
                        EmployeeId = ed.EmployeeId,
                        Employee = e.Firstname,
                        DepartmentId = ed.DepartmentId,
                        Department = d.DepartmentName,
                        StartDate = ed.StartDate,
                        EndDate = ed.EndDate
                    }).ToListAsync(); 
                    return new  Response<List<EmployeeDepartmentDto>>(list);
    }


    public async Task<Response<List<RegionDto>>> GetRegions()
    {
        var list = await (from r in _context.Regions
                    select new RegionDto()
                    {
                        Id = r.Id,
                        Name = r.Name,
                        NumberOfCountries = (from c in _context.Countries where c.RegionId == r.Id select c).Count()

                    }).ToListAsync();
                    return new Response<List<RegionDto>>(list);
    }

    public async Task<Response<List<EmployeeDto>>> GetEmployee()
    {
        var list = await (from d in _context.Departments
                          join e in _context.Employees on d.ManagerId equals e.Id
                          where e.Salary> 3000
                          group d by new {e.Id, FullName = string.Concat(e.FirstName," ", e.LastName), e.Salary} into g
                          select new EmployeeDto()
                          {
                            Id = g.Key.Id,
                            FullName = g.Key.FullName,
                            Salary = g.Key.Salary,
                            Departments = _mapper.Map<List<DepartmentDto>>(g.ToList())

                          }).ToListAsync();
                          return new Response<List<EmployeeDto>>(list);
    }

    public async Task<Response<List<DepartmentV2Dto>>> GetDepartment()
    {
        var list = await (from e in _context.Employees
                          join d in _context.Departments on e.Id equals d.ManagerId
                          group e by new {d.Id, d.DepartmentName } into g
                          select new DepartmentV2Dto()
                          {
                            Id = g.Key.Id,
                            DepartmentName = g.Key.DepartmentName,
                            Employees = _mapper.Map<List<EmployeeV2Dto>>(g.ToList())

                          }).ToListAsync();
                          return new Response<List<DepartmentV2Dto>>(list);
    }

    public async Task<Response<List<DepartmentV3Dto>>> GetDepartmentList()
    {
        var list = await (from d in _context.Departments
                          join e in _context.Employees on d.ManagerId equals e.Id
                          select new DepartmentV3Dto()
                          {
                            Id = d.Id,
                            DepartmentName = d.DepartmentName,
                            ManagerName = string.Concat(e.Firstname, " ", e.Lastname),

                          }).ToListAsync();
                          return new Response<List<DepartmentV3Dto>>(list);
    }

}

