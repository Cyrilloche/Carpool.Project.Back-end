using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Classroom> Classrooms { get; set; }
        public ICollection<Adress> Adresses { get; set; }
    }
}