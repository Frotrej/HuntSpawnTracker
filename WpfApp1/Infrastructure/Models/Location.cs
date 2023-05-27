using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Infrastructure.Models
{
    public class Location
    {
        public string Name { get; set; }
        [Key]
        public int Id { get; set; }
        public int LocationOccurrences { get; set; }
       
        public virtual Map Map { get; set; }
    }
}
