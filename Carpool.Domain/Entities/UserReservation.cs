using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class UserReservation
    {
        public DateTime ReservationDate { get; set; }
        public DateTime ResponseDate { get; set; }
        public bool Acceptation { get; set; }

        public int PassengerId { get; set; }
        public User Passenger { get; set; }
        public int TravelId { get; set; }
        public Travel Travel { get; set; }


    }
}