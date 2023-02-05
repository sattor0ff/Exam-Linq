using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Location
{
    [Key]
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string Address { get; set; }
    [Required,MaxLength(100)]
    public string City { get; set; }
    [Required,MaxLength(100)]   
    public string State { get; set; }
    public string ZipCode { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }

    public Location()
    {
        
    }

    public Location(int id, string address, string city, string state, string zipCode, int countryId)
    {
        Id = id;
        Address = address;
        City = city;
        State = state;
        ZipCode = zipCode;
        CountryId = countryId;
    }
}