using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Region
{
    [Key]
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string Name { get; set; }
    public List<Country> Countries { get; set; }

    public Region()
    {
        
    }

    public Region(int id, string name)
    {
        Id = id;
        Name = name;
    }
}