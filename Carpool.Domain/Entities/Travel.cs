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

        public int GoingAdressId { get; set; }
        public Adress GoingAdress { get; set; }

        public int ReturnAdressId { get; set; }
        public Adress ReturnAdress { get; set; }

        public virtual ICollection<UserReservation> UserReservations { get; set; }
        public virtual ICollection<TravelFilter> TravelFilters { get; set; }
        public virtual ICollection<TravelStage> TravelStages { get; set; }
    }
}