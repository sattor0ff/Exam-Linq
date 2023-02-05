using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Department
{
    [Key]
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string DepartmentName { get; set; }
    public int? ManagerId { get; set; }
    public Employee Manager { get; set; }
    public int  LocationId { get; set; }

    public Department()
    {
        
    }

    public Department(int id, string departmentName, int managerId, int locationId)
    {
        Id = id;
        DepartmentName = departmentName;
        ManagerId = managerId;
        LocationId = locationId;
    }
    
}