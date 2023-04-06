using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HuntSpawningTracker
{
    internal class FilesManagement
    {
        //pobiera lokalizacje do txt zawierajacych lokacje
        public static string GetPath2Names()
        {
            string currentdirectory = Directory.GetCurrentDirectory();//aktualna sciezka projektu
            System.Text.StringBuilder? pathBuilder = new System.Text.StringBuilder();//sciezka
            pathBuilder.Append(Directory.GetParent(currentdirectory)!.Parent!.Parent!.FullName).Append("\\Locations\\Locations-DeSalle.txt");
            string path = pathBuilder.ToString();
            return path;
        }

        //zapisuje
        public static void SaveSession(Map MapForSerialization)
        {
            string jsonString = JsonSerializer.Serialize(MapForSerialization);

            Console.WriteLine(jsonString);

            string path = "C:\\visual projects\\HuntSpawningTracker\\HuntSpawningTracker\\Sesions" + "\\deSale" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".json";
            File.WriteAllText(path, jsonString);

            Console.WriteLine("Serialization zakonczona.");
        }



    }
}
