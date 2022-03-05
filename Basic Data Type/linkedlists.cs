using System.Collections.Generic;

class linkedlists
{
    static void Maian(string[] args){
        var cities = new LinkedList<string>();

        cities.AddFirst("Seydişehir");
        cities.AddFirst("Konya");  
        cities.AddLast("Antalya");
 

        cities.AddAfter(cities.Find("Seydişehir"), "Alanya");
        cities.AddBefore(cities.First.Next.Next, "Akseki");
        cities.AddAfter(cities.Last.Previous, "Serik");

        foreach (string item in cities)
        {
            System.Console.Write(item + "->");
        }
        System.Console.WriteLine();

        var temp = cities.Last;

        while(temp != null){
            System.Console.Write(temp.Value + "->");
            temp = temp.Previous;
        }
    }
}