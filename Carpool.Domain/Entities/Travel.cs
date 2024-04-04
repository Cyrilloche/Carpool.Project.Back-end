using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class Travel
    {
        public int Id { get; set; }
        public TimeOnly TimeDeparture { get; set; }
        public DateOnly DateDeparture { get; set; }
        public int AvailablePlace { get; set; }
        public DateTime CreationDate { get; set; }

        public int PublisherId { get; set; }
        public User Publisher { get; set; }

        public ICollection<UserReservation> UserReservations { get; set; }
        public ICollection<TravelFilter> TravelFilters { get; set; }



    }
}