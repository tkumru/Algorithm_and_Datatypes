using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_and_Collections
{
    class main_array{
    static void Main(string[] args){
        var p1 = new Array_and_Collections.Array.Array<int> (1,2,3,4);
        var p2 = new int[] {8,9,10,11};
        var p3 = new List<int>() {6,7,3};
        var p4 = new ArrayList() {12,13,15};

        var arr = new Array_and_Collections.Array.Array<int>(p2);  // p1, p2, p3, p4 can get param with public Array(IEnumerable<T> collection)
        var clone_arr = (Array_and_Collections.Array.Array<int>) arr.Clone();  // casting because clone return object

        foreach (var item in arr)
        {
            
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine(arr);
        System.Console.WriteLine($"{arr.Count} / {arr.Capacity}");

        System.Console.WriteLine("-----------------------");

        foreach (var item in arr)
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"{clone_arr.Count} / {clone_arr.Capacity}");
    }
}
}
