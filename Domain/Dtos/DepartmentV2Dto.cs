using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos;

public class DepartmentV2Dto
{
    [Key]
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string DepartmentName { get; set; }
    public List<EmployeeV2Dto> Employees { get; set; }
}