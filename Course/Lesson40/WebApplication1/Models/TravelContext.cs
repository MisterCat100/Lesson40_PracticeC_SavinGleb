using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;
public class TravelContext : DbContext
{
    public DbSet<Order> Orders { get; set; } = null!;
    public TravelContext()
        : base()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .Build();

        optionsBuilder.UseSqlite(config.GetConnectionString("DefaultConnection"));
    }
}
