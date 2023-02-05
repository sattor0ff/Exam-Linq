using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Country
{
    [Key]
    public int  Id { get; set; }
    [Required,MaxLength(100)]
    public string Name { get; set; }
    public int RegionId { get; set; }
    public Region Region { get; set; }
    public List<Location> Locations { get; set; }

    public Country()
    {
        
    }

    public Country(int id, string name, int regionId)
    {
        Id = id;
        Name = name;
        RegionId = regionId;
    }
}