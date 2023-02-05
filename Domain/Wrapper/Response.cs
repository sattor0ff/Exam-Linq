using System.Net;
using Domain.Dtos;

namespace Domain.Wrapper;

public class Response<T>
{
    private Task<List<EmployeeDepartmentDto>> list;
    private Task<List<RegionDto>> list1;

    public T Data { get; set; }
    public List<string> Errors { get; set; }
    public int StatusCode { get; set; }

    public Response(T data)
    {
        Data = data;
        Errors = new List<string>();
        StatusCode = 200;
    }
    
    public Response(HttpStatusCode statusCode, List<string> errors)
    {
        Errors = errors;
        StatusCode = (int)statusCode;
    }

    public Response(Task<List<EmployeeDepartmentDto>> list)
    {
        this.list = list;
    }

    public Response(Task<List<RegionDto>> list1)
    {
        this.list1 = list1;
    }
}