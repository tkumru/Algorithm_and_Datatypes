using System.Collections;

class sorted_list
{
    static void Maisn(string[] args){
        var cities = new SortedList();

        cities.Add(7, "Antalya");
        cities.Add(42, "Konya");

        foreach (DictionaryEntry city in cities)
        {
            System.Console.WriteLine($"{city.Key, -7} - {city.Value, -7}");
        }

        System.Console.WriteLine();

        System.Console.WriteLine("Length: " + cities.Count);
        System.Console.WriteLine("Capasity: " + cities.Capacity);

        cities.TrimToSize();

        System.Console.WriteLine("Capasity: " + cities.Capacity);
        System.Console.WriteLine("Key index:" + cities[7]);
        System.Console.WriteLine("Getbyindex: " + cities.GetByIndex(0));
        System.Console.WriteLine("Getkey: " + cities.GetKey(0));
    }
}