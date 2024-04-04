using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class TravelStage
    {
        public int TravelId { get; set; }
        public Travel Travel { get; set; }
        public int AdressId { get; set; }
        public Adress Adress { get; set; }
    }
}