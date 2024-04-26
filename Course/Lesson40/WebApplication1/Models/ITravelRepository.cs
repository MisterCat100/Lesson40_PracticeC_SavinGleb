namespace WebApplication1.Models;

public interface ITravelRepository
{
    public List<Order> Search(string origin, string destination);
    public void Add(Order order);
    public void Delete(long id);
}
