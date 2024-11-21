using ParkXplore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkXplore.Core.Interfaces
{
    public interface IParkingSpotService
    {
        Task<List<ParkingSpot>> GetAvailableSpotsAsync();
    }
}
