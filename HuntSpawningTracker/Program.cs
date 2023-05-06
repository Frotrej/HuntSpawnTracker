using HuntSpawningTracker;
using System;
using System.ComponentModel.Design;
using System.Text.Json;

string path = FilesManagement.GetPath2MapsFolder();      //sciezka do folderu z Mapami i ich lokalizacjami

string[] MapPaths = FilesManagement.GetAllMapsPaths(path);
string[] MapNames = Utilities.GetMapNamesFromPath(MapPaths);

Maps maps = new Maps(MapPaths);


string? input = null;
do
{
    if (input != null) Console.WriteLine("\n");
    Console.WriteLine("Wybierz akcje");
    Console.WriteLine("1. Pokaz mape\n2. Pokaz statystyki sesji\n3. Dodaj Spawn w lokacji\n4. Zapisz biezaca sesje\nexit");
    input = Console.ReadLine();

    Console.Clear();

    int helperVal = default;
    if (input == "1")
    {
        maps.DisplayMaps();
        helperVal = int.Parse(Console.ReadLine()) - 1;

        Console.Clear();
        maps.DisplayMapAndLocations(MapNames[helperVal]);
    }
    else if (input == "2") Console.WriteLine("nie dziala jeszcze");
    else if (input == "3")
    {
        maps.DisplayMaps();

        helperVal = int.Parse(Console.ReadLine()) - 1;
        Map map = maps.GetMapByName(MapNames[helperVal]);

        Console.Clear();
        maps.DisplayMap(map);
        map.DisplayLocations();

        Console.WriteLine("\nWprowadz ID lokacji w ktorej sie pojawiles:");
        helperVal = int.Parse(Console.ReadLine());
        while (helperVal > map.GetNumberOfLocations() - 1 || helperVal < 0)
        {
            Console.WriteLine("Podaj ID lokacji:");
            helperVal = int.Parse(Console.ReadLine());
        }
        maps.IncrementMapLocationOccurrences(map, helperVal);

    }
    else if (input == "4")
    {
        Console.WriteLine("Na pewno? t/n");
        if (Console.ReadLine() == "t") FilesManagement.SaveSession(maps);
    }
    else if (input == "exit" || input == "e") break;
    else Console.WriteLine("Nierozpoznano komendy.");

} while (input != "exit");

