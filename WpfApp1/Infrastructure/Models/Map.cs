using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Infrastructure.Models
{
    public class Map
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int MapOccurrences { get; set; }

        public virtual List<Location> Locations { get; set; }
    }
}
