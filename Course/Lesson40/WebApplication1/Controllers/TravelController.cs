using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[]
public class TravelController : ControllerBase
{
    private readonly TravelRepository _repository;

    public TravelController(TravelRepository repository)
    {
        _repository = repository;
    }

    [HttpGet("/api/carpool/search")]
    public void
}
