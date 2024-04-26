
namespace WebApplication1.Models;
public class TravelRepository : ITravelRepository
{
    private readonly TravelContext _context;

    public TravelRepository(TravelContext context)
    {
        _context = context;
    }

    public void Add(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }

    public void Delete(long id)
    {
        var order = _context.Orders.FirstOrDefault(o => o.Id == id);

        if (order != null)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }

    public List<Order> Search(string origin, string destination)
    {
        return _context.Orders.Where(o => o.Origin == origin && o.Destination == destination).ToList();
    }
}
