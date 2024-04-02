using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class Status
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public ICollection<User>? Users { get; set; }
    }
}