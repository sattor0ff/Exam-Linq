using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos;

public class DepartmentV3Dto
{
    [Key]
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string DepartmentName { get; set; }
    public string DepartmentCountry { get; set; }
    public string ManagerName { get; set; }
    public int NumberOfEmployee { get; set; }
    public string DepartmentCity { get; set; }
}