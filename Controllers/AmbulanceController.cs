using AmbuBolt.Models;
using AmbuBolt.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmbuBolt.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AmbulanceController : ControllerBase
{
    private readonly GoogleMapsService _service;
    
    public AmbulanceController(GoogleMapsService googleMapsService)
    {
        _service = googleMapsService;
    }
    
    [HttpGet]
    public async Task<DirectionsData> GetEstimatedTimes(string origin, string destination)
    {
        return await _service.GetEstimatedTimesAsync(origin, destination);
    }
}