using ParkXplore.Core.Entities;
using ParkXplore.Core.Interfaces;
using ParkXplore.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkXplore.Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IRepository<Reservation> _reservationRepository;

        public ReservationService(IRepository<Reservation> reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<bool> MakeReservationAsync(int userId, int parkingSpotId, DateTime start, DateTime end)
        {
            var isAvailable = await ((ReservationRepository)_reservationRepository)
                .IsSpotAvailableAsync(parkingSpotId, start, end);

            if (!isAvailable) return false;

            var reservation = new Reservation
            {
                UserId = userId,
                ParkingSpotId = parkingSpotId,
                ReservationStart = start,
                ReservationEnd = end
            };

            await _reservationRepository.AddAsync(reservation);
            return await _reservationRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<Reservation>> GetUserReservationsAsync(int userId)
        {
            return await ((ReservationRepository)_reservationRepository).GetUserReservationsAsync(userId);
        }

        public Task<bool> CancelReservationAsync(int reservationId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Reservation>> GetReservationsByParkingSpotAsync(int parkingSpotId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExtendReservationAsync(int reservationId, DateTime newEndTime)
        {
            throw new NotImplementedException();
        }
    }
}
