using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;


[Route("[controller]")]


public class AllController:ControllerBase
{       
        private readonly AllService _allService;

        public AllController(AllService allService)
        {
                _allService = allService;
        }

        [HttpGet("DepartmentTime")]
        public async Task<Response<List<EmployeeDepartmentDto>>> GetDepatrmentTime()
        {
                return await _allService.GetDepatrmentTime();
        }

        [HttpGet("GetRegions")]
        public async Task<Response<List<RegionDto>>> GetRegions()
        {
                return await _allService.GetRegions();
        }

        [HttpGet("GetEmployee")]
        public async Task<Response<List<EmployeeDto>>> GetEmployee()
        {
                return await _allService.GetEmployee();
        }

        [HttpGet("GetDepartment")]
        public async Task<Response<List<DepartmentV2Dto>>> GetDepartment()
        {
                return await _allService.GetDepartment();
        }

        [HttpGet("GetDepartmentList")]
        public async Task<Response<List<DepartmentV3Dto>>> GetDepartmentList()
        {
                return await _allService.GetDepartmentList();
        }
}