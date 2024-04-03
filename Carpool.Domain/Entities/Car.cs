using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public string CarBrand { get; set; } = string.Empty;
        public string CarModel { get; set; } = string.Empty;
        public string CarPaintColor { get; set; } = string.Empty;
        public string CarRegistration { get; set; } = string.Empty;
        public string CarPicture { get; set; } = string.Empty;


        public int UserID { get; set; }
        public User User { get; set; }

        public int FuelID { get; set; }
        public Fuel Fuel { get; set; }
    }
}