using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class Filter
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<TravelFilter> TravelFilters { get; set; }
    }
}