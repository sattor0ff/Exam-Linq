using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos;

public class EmployeeV2Dto
{
    
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string FirstName { get; set; }
    [Required,MaxLength(100)]
    public string LastName { get; set; }
    [Required,MaxLength(100)]
    public string Email { get; set; }
    [Required,MaxLength(50)]
    public string PhoneNumber { get; set; }
    public decimal Salary { get; set; }
}