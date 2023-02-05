using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeDepartment> EmployeeDepartments { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Region> Regions { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeDepartment>().HasKey(x => new { x.DepartmentId, x.EmployeeId});
        
        base.OnModelCreating(modelBuilder);
    }
}