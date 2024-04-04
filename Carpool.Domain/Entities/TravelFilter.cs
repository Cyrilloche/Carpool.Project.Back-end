using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class TravelFilter
    {
        public int TravelId { get; set; }
        public Travel Travel { get; set; }
        public int FilterId { get; set; }
        public Filter Filter { get; set; }
    }
}