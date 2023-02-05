
namespace Domain.Entities;

public class EmployeeDepartment
{
    
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public EmployeeDepartment(int employeeId, int departmentId, DateTime startDate, DateTime endDate)
    {
        EmployeeId = employeeId;
        DepartmentId = departmentId;
        StartDate = startDate;
        EndDate = endDate;
    }

    public EmployeeDepartment()
    {
        
    }
}