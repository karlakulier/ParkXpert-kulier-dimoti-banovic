using ParkXplore.Core.Entities;

namespace ParkXplore.Application.Services
{
    public interface IReservationService
    {
        Task<bool> MakeReservationAsync(int userId, int parkingSpotId, DateTime start, DateTime end);
        Task<IEnumerable<Reservation>> GetUserReservationsAsync(int userId);
        Task<bool> CancelReservationAsync(int reservationId);
        Task<IEnumerable<Reservation>> GetReservationsByParkingSpotAsync(int parkingSpotId);
        Task<bool> ExtendReservationAsync(int reservationId, DateTime newEndTime);
    }
}