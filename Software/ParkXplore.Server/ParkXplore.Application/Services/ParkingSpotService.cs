using ParkXplore.Core.Entities;
using ParkXplore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkXplore.Application.Services
{
    public class ParkingSpotService : IParkingSpotService
    {
        private readonly IRepository<ParkingSpot> _parkingSpotRepository;

        public ParkingSpotService(IRepository<ParkingSpot> parkingSpotRepository)
        {
            _parkingSpotRepository = parkingSpotRepository;
        }

        public async Task<List<ParkingSpot>> GetAvailableSpotsAsync()
        {
            var allSpots = await _parkingSpotRepository.GetAllAsync();
            return allSpots.Where(spot => spot.IsAvailable).ToList();
        }
    }
}
