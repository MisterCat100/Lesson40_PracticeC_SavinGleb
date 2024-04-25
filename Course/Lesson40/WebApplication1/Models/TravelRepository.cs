
namespace WebApplication1.Models;
public class TravelRepository : ITravelRepository
{
    private readonly TravelContext _context;

    public TravelRepository(TravelContext context)
    {
        _context = context;
    }

    public void Add(Traveler traveler)
    {
        _context.Travelers.Add(traveler);
        _context.SaveChanges();
    }

    public void Delete(long id)
    {
        var traveler = _context.Travelers.FirstOrDefault(t => t.Id == id);

        if (traveler != null)
        {
            _context.Travelers.Remove(traveler);
        }
    }

    public List<Traveler> Search(string origin, string destination)
    {
        return _context.Travelers.ToList();
    }
}
