using System.Collections;

class list
{
    static void asda(string[] args){
        List<int> numbers = new List<int>();

        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        foreach (int item in numbers)
        {
            System.Console.WriteLine(item + " ");
        }
    }
}