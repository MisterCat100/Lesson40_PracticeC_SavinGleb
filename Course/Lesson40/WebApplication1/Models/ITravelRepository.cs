namespace WebApplication1.Models;

public interface ITravelRepository
{
    public List<Traveler> Search(string origin, string destination);
    public void Add(Traveler traveler);
    public void Delete(long id);
}
