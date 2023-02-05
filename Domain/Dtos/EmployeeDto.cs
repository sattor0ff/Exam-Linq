using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos;

public class EmployeeDto
{
    [Key]
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string FullName { get; set; }
    public decimal Salary { get; set; }
     public List<DepartmentDto> Departments { get; set; }
}