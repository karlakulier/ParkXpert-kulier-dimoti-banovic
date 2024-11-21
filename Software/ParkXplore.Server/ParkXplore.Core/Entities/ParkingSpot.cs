using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkXplore.Core.Entities
{
    public class ParkingSpot
    {
        public int Id { get; set; }
        public int ParkingId { get; set; }
        public int ParkingSpotTypeId { get; set; }
        public bool IsAvailable { get; set; }

        
        public Parking? Parking { get; set; }
        public ParkingSpotType Type { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
