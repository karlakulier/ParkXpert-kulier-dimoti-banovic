using Microsoft.EntityFrameworkCore;
using ParkXplore.Core.Entities;
using ParkXplore.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkXplore.Infrastructure.Repositories
{
    public class ParkingSpotRepository : Repository<ParkingSpot>
    {
        public ParkingSpotRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ParkingSpot>> GetAvailableSpotsAsync()
        {
            return await _context.Set<ParkingSpot>()
                .Where(spot => spot.IsAvailable)
                .ToListAsync();
        }
    }
}
