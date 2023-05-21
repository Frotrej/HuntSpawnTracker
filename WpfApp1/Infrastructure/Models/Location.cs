using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Infrastructure.Models
{
    public class Location
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int LocationOccurrences { get; set; }

        public virtual Map Map { get; set; }
    }
}
