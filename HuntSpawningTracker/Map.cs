using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace HuntSpawningTracker
{
    //Klasa Map odpowiada za zarzadzanie pojedyńczą mapą
    internal class Map
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int MapOccurrences { get; set; } //number of spawns in this map
        public List<Location> Locations { get; set; }
        

        public Map(string mapName, int mapId)
        {
            Name = mapName;
            Locations = new List<Location>();
            Id = mapId;
            MapOccurrences = default;
        }
        //--- METODY
        public int GetNumberOfLocations()
        {
            return Locations.Count();
        }
        //dodaje lokacje bazując na ciagu nazw oddzielonych ,
        public void AddLocations(string locationsNames)
        {
            foreach (var locationName in locationsNames.Split(','))
            {
                Locations.Add(new Location(locationName, GetNumberOfLocations()));
            }
        }
        public void DisplayLocations()
        {
            Console.WriteLine($"ID\tLocation Name: wystapienia");
            foreach (var item in Locations)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}: {item.LocationOccurrences}");
            }
        }
        public void GetSpawnNumbers()
        {
            Console.WriteLine($"ID\tLocation Name");
            foreach (var item in Locations)
            {
                Console.WriteLine($"{item.Name}:{item.LocationOccurrences}");
            }
        }
        public void IncrementMapOccurencess(int locationId)
        {
            MapOccurrences++;
        }
        public int GetTotalSpawnsOnMap()
        {
            int temp = default;
            foreach(var item in Locations)
            {
                temp += item.LocationOccurrences;
            }
            return temp;
        }
    }
}
