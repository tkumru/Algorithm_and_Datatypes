using System.Collections.Generic;

class dicts
{
    static void Maina(string[] args){
        var cities = new Dictionary<int, string>();

        cities.Add(7, "Antalya");
        cities.Add(42, "Konya");
        cities.Add(6, "Ankara");
        cities[35] = "İzmir";

        cities.ContainsKey(1);  // Controlled is there Adana

        foreach (var item in cities)
        {
            System.Console.Write(item + " ");
        }

    }
}