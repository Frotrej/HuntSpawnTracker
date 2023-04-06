using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace HuntSpawningTracker
{
    internal class Map
    {
        public string Name { get; set; }
        public int MapOccurrences { get; set; } //number of spawns in this map
        public List<Location> Locations { get; set; }
        

        public Map(string mapName)
        {
            Name = mapName;
            Locations = new List<Location>();
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
            Console.WriteLine($"ID\tLocation Name");
            foreach (var item in Locations)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}");
            }
        }
        public void DisplaySpawnNumbers()
        {
            Console.WriteLine($"ID\tLocation Name");
            foreach (var item in Locations)
            {
                Console.WriteLine($"{item.Name}:{item.NumberOfSpawns}");
            }
        }
        public void IncreaseSpawnCounter(string locationId)
        {
            var tempLocation = Locations.FirstOrDefault(x => x.Id == Convert.ToInt32(locationId));

            if (tempLocation != null)
            {
                tempLocation.NumberOfSpawns++;
                Console.WriteLine("Spawn w tej lokacji +1");
            }
            else Console.WriteLine($"Lokacja o ID {locationId} nie zostala znaleziona");
        }
    }
}
