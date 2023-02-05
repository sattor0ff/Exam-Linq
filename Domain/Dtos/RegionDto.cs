using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos;

public class RegionDto
{
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int NumberOfCountries { get; set; }
}