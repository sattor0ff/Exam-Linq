using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos;

public class EmployeeDepartmentDto
{
    public int EmployeeId { get; set; }
    public string Employee { get; set; }
    public int DepartmentId { get; set; }
    public string Department { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}