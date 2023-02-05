using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos;

public class DepartmentDto
{
    [Key]
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string DepartmentName { get; set; }
    
}