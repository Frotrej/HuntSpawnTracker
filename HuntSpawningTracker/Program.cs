using HuntSpawningTracker;
using System;
using System.ComponentModel.Design;
using System.Text.Json;

string path = FilesManagement.GetPath2Names();      //sciezka do listy lokalizacji
string locationsNames = File.ReadAllText(path);     //wczytaj liste lokalizacji


Map deSale = new Map("DeSale");
deSale.AddLocations(locationsNames);



string? input = null;
do
{
    if (input != null) Console.WriteLine("\n");
    Console.WriteLine("Wybierz akcje");
    Console.WriteLine("1. Pokaz wszystko\n2. Pokaz statystyki sesji\n3. Dodaj Spawn w lokacji\n4. Save current session\nexit");
    input = Console.ReadLine();

    Console.Clear();

    if (input == "1") deSale.DisplayLocations();
    else if (input == "2") deSale.DisplaySpawnNumbers();
    else if (input == "3")
    {
        deSale.DisplayLocations();

        Console.WriteLine("\nWprowadz ID lokacji w ktorej sie pojawiles:");
        string locationName = Console.ReadLine()!;

        deSale.IncreaseSpawnCounter(locationName);
    }
    else if (input == "4") FilesManagement.SaveSession(deSale);
    else if (input == "exit") break;
    else Console.WriteLine("Nierozpoznano komendy.");

} while (input != "exit");

