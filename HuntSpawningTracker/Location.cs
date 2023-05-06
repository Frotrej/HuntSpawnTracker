using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntSpawningTracker
{
    internal class Location
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int LocationOccurrences { get; set; }
        

        public Location(string locationName,int id)
        {
            Id = id;
            LocationOccurrences = 0;
            Name = locationName;
        }
        //--- METODY
        public void IncreaseNumberOfSpawns()
        {
            LocationOccurrences++;
            Console.WriteLine($"Spawn w tej lokacji +1.\nAktualnie {LocationOccurrences} wystapien.");
        }
    }
}
