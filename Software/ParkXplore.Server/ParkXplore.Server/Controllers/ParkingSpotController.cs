using Microsoft.AspNetCore.Mvc;
using ParkXplore.Core.Entities;
using ParkXplore.Application.Services;
using ParkXplore.Core.Interfaces;

namespace ParkXplore.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParkingSpotController : ControllerBase
    {
        private readonly IParkingSpotService _parkingSpotService;

        public ParkingSpotController(IParkingSpotService parkingSpotService)
        {
            _parkingSpotService = parkingSpotService;
        }

        [HttpGet("available")]
        public async Task<IActionResult> GetAvailableSpots()
        {
            var spots = await _parkingSpotService.GetAvailableSpotsAsync();
            return Ok(spots);
        }
    }
}