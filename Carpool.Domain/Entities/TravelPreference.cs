using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class TravelPreference
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<UserTravelPreference> UserTravelPreferences { get; set; }


    }
}