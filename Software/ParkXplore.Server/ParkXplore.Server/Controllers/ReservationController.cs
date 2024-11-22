using Microsoft.AspNetCore.Mvc;
using ParkXplore.Application.Services;
using ParkXplore.Core.Entities;
using ParkXplore.Core.Interfaces;

namespace ParkXplore.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        public async Task<IActionResult> MakeReservation(int userId, int parkingSpotId, DateTime start, DateTime end)
        {
            var result = await _reservationService.MakeReservationAsync(userId, parkingSpotId, start, end);
            if (result)
                return Ok("Reservation created successfully.");
            return BadRequest("Parking spot is not available.");
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetUserReservations(int userId)
        {
            var reservations = await _reservationService.GetUserReservationsAsync(userId);
            return Ok(reservations);
        }
    }
}
