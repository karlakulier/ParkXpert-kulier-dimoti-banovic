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
    public class ReservationRepository : Repository<Reservation>
    {
        public ReservationRepository(AppDbContext context) : base(context)
        {
        }
        
        public async Task<IEnumerable<Reservation>> GetUserReservationsAsync(int userId)
        {
            return await _context.Reservations
                .Include(r => r.ParkingSpot)
                .Include(r => r.User)
                .Where(r => r.UserId == userId)
                .ToListAsync();
        }
        
        public async Task<bool> IsSpotAvailableAsync(int parkingSpotId, DateTime start, DateTime end)
        {
            return !await _context.Reservations
                .AnyAsync(r => r.ParkingSpotId == parkingSpotId &&
                               r.ReservationEnd > start &&
                               r.ReservationStart < end);
        }
        
        public async Task<IEnumerable<Reservation>> GetReservationsByParkingSpotAsync(int parkingSpotId)
        {
            return await _context.Reservations
                .Include(r => r.User)
                .Where(r => r.ParkingSpotId == parkingSpotId)
                .ToListAsync();
        }
   
        public async Task<IEnumerable<Reservation>> GetReservationsInTimeRangeAsync(DateTime start, DateTime end)
        {
            return await _context.Reservations
                .Include(r => r.ParkingSpot)
                .Include(r => r.User)
                .Where(r => r.ReservationStart < end && r.ReservationEnd > start)
                .ToListAsync();
        }

        public async Task<Reservation?> GetUserReservationForSpotAsync(int userId, int parkingSpotId)
        {
            return await _context.Reservations
                .Include(r => r.ParkingSpot)
                .Include(r => r.User)
                .FirstOrDefaultAsync(r => r.UserId == userId && r.ParkingSpotId == parkingSpotId);
        }
    }
}
