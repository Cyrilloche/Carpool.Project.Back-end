using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class Adress
    {
        public int Id { get; set; }
        public string AdressName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int PostalCode { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; }

        public virtual ICollection<Travel> GoingTravel { get; set; }
        public virtual ICollection<Travel> ReturnTravel { get; set; }
        public virtual ICollection<TravelStage> TravelStages { get; set; }
    }
}