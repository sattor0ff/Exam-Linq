using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Employee:Person
{
    [Key]
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
    public int JobId { get; set; }
    public Job Job { get; set; }
    public int ManagerId { get; set; }
    public Employee Manager { get; set; }
    public DateTime HireDate { get; set; }

    
    public Employee(int id, string firstname, string lastname, string email, string phoneNumber, decimal salary, int jobId, int managerId, DateTime hireDate)
    {
        Id = id;
        Email = email;
        PhoneNumber = phoneNumber;
        Salary = salary;
        JobId = jobId;
        ManagerId = managerId;
        HireDate = hireDate;
    }
    public Employee()
    {
        
    }
   
}