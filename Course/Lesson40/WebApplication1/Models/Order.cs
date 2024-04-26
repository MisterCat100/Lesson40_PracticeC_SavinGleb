using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Order
{
    public long Id { get; set; }
    public DateTime? Date { get; set; } = DateTime.Now;
    [Required]
    public double Price { get; set; }
    [Required]
    public required string Origin { get; set; }
    [Required]
    public required string Destination { get; set; }
    [Required]
    public required string Traveler { get; set; }
}
