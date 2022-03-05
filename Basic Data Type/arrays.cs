class Arrays
{
    static void Maiasn(string[] args){
        var numbers = Array.CreateInstance(typeof(int), 5);

        numbers.SetValue(1,0);
        numbers.SetValue(5,1);
        numbers.SetValue(6,2);
        numbers.SetValue(7,3);
        numbers.SetValue(8,4);

        foreach (var item in numbers)
        {
            System.Console.Write(item + " ");
        }
    }
}