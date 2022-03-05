using System.Collections;

class arraylist
{
    static void Masdasn(string[] args){
        ArrayList arrayList = new ArrayList();

        arrayList.Add(10);
        arrayList.Add("Talha Nebi Kumru");
        arrayList.Add(false);

        int[] numbers = new int[] {1,2,3};

        arrayList.AddRange(numbers);

        arrayList.Remove(10); // remove 10
        arrayList.RemoveAt(1);  // remove 1. index

        foreach (var item in arrayList)
        {
            System.Console.Write(item + " ");
        }
    }
}