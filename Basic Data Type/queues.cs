using System.Collections.Generic;

class queues
{
    static void Maain(string[] args){
        var c = new Queue<char>();  // first in first out

        c.Enqueue('T');
        c.Enqueue('a');
        c.Enqueue('l');
        c.Enqueue('h');
        c.Enqueue('a');

        System.Console.WriteLine(c.ToArray());
        System.Console.WriteLine("Length: " + c.Count);
        System.Console.WriteLine(c.Dequeue()); // remove firts index and return
        System.Console.WriteLine(c.ToArray());
        System.Console.WriteLine("Length: " + c.Count);
    }
}