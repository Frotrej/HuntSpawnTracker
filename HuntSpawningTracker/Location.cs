using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntSpawningTracker
{
    internal class Location
    {
        public int Id { get; set; }
        public int NumberOfSpawns { get; set; } //number of spawns in this location
        public string Name { get; set; }

        public Location(string locationName,int id)
        {
            Id = id;
            NumberOfSpawns = 0;
            Name = locationName;
        }
        //--- METODY
    }
}
