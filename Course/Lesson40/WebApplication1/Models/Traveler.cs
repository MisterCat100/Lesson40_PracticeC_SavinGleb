using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Traveler
{
    public long Id { get; set; }
    [Required]
    public required string Name { get; set; }

}
