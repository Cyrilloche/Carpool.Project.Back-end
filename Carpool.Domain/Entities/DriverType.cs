using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class DriverType
    {
        public int DriverTypeID { get; set; }
        public string DriverTypeName { get; set; } = string.Empty;
        public ICollection<User>? Users { get; set; }
    }
}