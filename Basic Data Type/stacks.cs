using System.Collections;

class stacks
{
    static void Maina(string[] args){
        var c = new Stack<char>();  // last in first out

        c.Push('T');
        System.Console.WriteLine(c.Peek());  // show last added
        c.Push('a');
        System.Console.WriteLine(c.Peek());
        c.Push('l');
        System.Console.WriteLine(c.Peek());
        c.Push('h');
        System.Console.WriteLine(c.Peek());
        c.Push('a');
        System.Console.WriteLine(c.Peek());

        //System.Console.WriteLine(c.Pop());// removes, swap, return

        System.Console.WriteLine(c.ToArray());
    }
}