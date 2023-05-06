using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntSpawningTracker
{
    internal class Maps
    {
        public List<Map> Allmaps = new List<Map>();

        public Maps(string[] mapPaths)
        {
            AddMaps(mapPaths);
        }
        public void AddMaps(string[] mapPaths)
        {
            string[] mapNames = Utilities.GetMapNamesFromPath(mapPaths);
            for (int i = 0; i < mapPaths.Length; i++)
            {
                Allmaps.Add(new Map(mapNames[i], Allmaps.Count));

                Map map = Allmaps.FirstOrDefault(p => p.Name == mapNames[i]); //jak ogarnac zeby VS nie zwracal ostrzezenia o Null, nie chce uzywac '!'

                string fileContents = FilesManagement.GetAllLinesInTxtFile(mapPaths[i]);
                map.AddLocations(fileContents);
            }
        }
        public void DisplayMap(Map map)
        {
            Console.WriteLine($"{map.Id + 1}. {map.Name}: {map.GetNumberOfLocations()} mozliwych lokacji do pojawienia sie.");
        }
        public void DisplayMaps()
        {
            foreach (Map map in Allmaps)
            {
                DisplayMap(map);
            }
        }
        public void DisplayMapAndLocations(string nameOfMap)
        {
            var tempMap = GetMapByName(nameOfMap);
            Console.WriteLine($"{tempMap.Name} total spawns: {tempMap.GetTotalSpawnsOnMap()}");
            tempMap.DisplayLocations();
        }
        public void IncrementMapLocationOccurrences(Map map, int locationId)
        {
            var tempLocation = map.Locations.FirstOrDefault(x => x.Id == locationId);

            if (tempLocation != null)
            {
                map.IncrementMapOccurencess(locationId);
                tempLocation.IncreaseNumberOfSpawns();
            }
            else Console.WriteLine($"Lokacja o ID {locationId} nie zostala znaleziona");
        }
        public void DisplayStatistics(Map map)
        {
            Console.WriteLine($"{map.Id + 1}. {map.Name}: {map.GetNumberOfLocations()} possible spawn locations");
        }
        public Map GetMapByName(string nameOfMap)
        {
            return Allmaps.FirstOrDefault(p => p.Name == nameOfMap);
        }
        public List<Map> GetAllMaps()
        {
            return Allmaps;
        }
    }
}
