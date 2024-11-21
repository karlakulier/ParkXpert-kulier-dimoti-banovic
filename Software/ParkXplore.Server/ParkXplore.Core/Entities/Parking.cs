using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkXplore.Core.Entities
{
    public class Parking
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int ParkingTypeId { get; set; }

        public ParkingType Type { get; set; }
        public ICollection<ParkingSpot>? ParkingSpots { get; set; }
    }
}
