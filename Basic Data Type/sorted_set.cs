using System.Collections.Generic;

class sorted_set
{
    static void Maain(string[] args){
        var a = new SortedSet<int>() {1,2,3,4};
        var b = new SortedSet<int>() {1,2,3,4,5,6};

        

        #region printed
        System.Console.WriteLine("a:");
        foreach (int item in a)
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine("b:");
        foreach (int item in b)
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine();
        #endregion

        #region b // a
        b.ExceptWith(a);
        System.Console.WriteLine("b // a:");
        foreach (int item in b)
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine();
        #endregion

        #region and
        a.Intersect(b);
        System.Console.WriteLine("a and b:");
        foreach (int item in a)
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine();
        #endregion

        #region or
        a.UnionWith(b);
        System.Console.WriteLine("a or b:");
        foreach (int item in a)
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine();
        #endregion
    }
}