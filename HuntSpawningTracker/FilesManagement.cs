using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HuntSpawningTracker
{
    internal class FilesManagement
    {
        public static string GetPath2MapsFolder()
        {
            System.Text.StringBuilder? pathBuilder = new System.Text.StringBuilder();//sciezka, uzycie stringbuildera nie jest przemyslane
            pathBuilder.Append(GetDirectoryPath()).Append("\\Locations");
            string path = pathBuilder.ToString();
            return path;
        }
        public static string[] GetAllMapsPaths(string path)
        {
            string[] fileNames = Directory.GetFiles(path, "*.txt");

            return fileNames;
        }
        public static void SaveSession(Maps MapsForSerialization)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
                IncludeFields = true,
                WriteIndented = true
            };

            string serializedSesion = JsonSerializer.Serialize(MapsForSerialization,options);
            Console.WriteLine(serializedSesion);

            System.Text.StringBuilder? path = new System.Text.StringBuilder();
            path.Append(GetDirectoryPath()).Append("\\Sesions").Append("\\sesion_").Append(DateTime.Now.ToString("yyyyMMdd_HHmmss")).Append(".json");

            File.WriteAllText(path.ToString(), serializedSesion);

            Console.WriteLine("Serialization zakonczona.");
        }
        public static string GetAllLinesInTxtFile(string path)
        {
            return File.ReadAllText(path);
        }
        public static string GetDirectoryPath()
        {
            return Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
        }
    }
}
