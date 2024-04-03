using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class UserTravelPreference
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int TravelPreferenceID { get; set; }
        public TravelPreference TravelPreference { get; set; }
    }
}