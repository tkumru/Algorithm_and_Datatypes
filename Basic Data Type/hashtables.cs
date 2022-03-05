using System.Collections;

class hashtables
{
    static void Maian(string[] args){
        var cities = new Hashtable();

        cities.Add(7, "Antalya");
        cities.Add(42, "Konya");

        foreach (DictionaryEntry city in cities)
        {
            System.Console.WriteLine($"{city.Key, -7} - {city.Value, -7}");
        }

        System.Console.WriteLine();

        System.Console.WriteLine(cities[7]);
    }
}