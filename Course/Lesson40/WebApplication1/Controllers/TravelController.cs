using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[Route("api/carpool")]
public class TravelController : ControllerBase
{
    private readonly TravelRepository _repository;

    public TravelController(TravelRepository repository)
    {
        _repository = repository;
    }

    [HttpGet("search")]
    public List<Order> Search(string origin, string destination)
    {
        return _repository.Search(origin, destination);
    }

    [HttpPost("add")]
    public void Add([FromBody] Order order)
    {
        _repository.Add(order);
    }

    [HttpDelete("{id}/delete")]
    public void Delete(long id)
    {
        _repository.Delete(id);
    }
}
