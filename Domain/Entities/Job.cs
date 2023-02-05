using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Job
{
    [Key]
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string Title { get; set; }
    public decimal MinSalary { get; set; }
    public decimal MaxSalary { get; set; }
    public List<Employee> Employees { get; set; }


public Job(int id, string title, decimal minSalary, decimal maxSalary)
{
    Id = id;
    Title = title;
    MinSalary = minSalary;
    MaxSalary = maxSalary;

}

public Job()
{
    
}

}