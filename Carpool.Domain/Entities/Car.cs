using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string PaintColor { get; set; } = string.Empty;
        public string Registration { get; set; } = string.Empty;
        public string Picture { get; set; } = string.Empty;


        public int UserID { get; set; }
        public User User { get; set; }

        public int FuelID { get; set; }
        public Fuel Fuel { get; set; }
    }
}