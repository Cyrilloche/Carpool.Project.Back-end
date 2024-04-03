using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class Fuel
    {
        public int FuelID { get; set; }
        public string FuelName { get; set; } = string.Empty;

        public ICollection<Car>? Cars { get; set; }


    }
}