using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class UserTravelPreference
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int TravelPreferenceId { get; set; }
        public TravelPreference TravelPreference { get; set; }
    }
}