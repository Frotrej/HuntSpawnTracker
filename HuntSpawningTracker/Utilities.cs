using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntSpawningTracker
{
    internal class Utilities
    {
        public static string[] GetMapNamesFromPath(string[] mapsPaths)
        {
            string[] tempString = new string[mapsPaths.Length];
            for (int i = 0; i < mapsPaths.Length; i++)
            {
                tempString[i] = Path.GetFileNameWithoutExtension(mapsPaths[i]);
            }
            return tempString;
        }
        public static int UserInputToInt(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("bledna wartosc");
                return default(int);
            }
        }
    }
}
