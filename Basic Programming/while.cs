class While
{
    static void wh(string[] args){
        Console.WriteLine("Number: ");

        int number = Convert.ToInt32(Console.ReadLine());

        while(number < 10){
            number++;
        }
    }
}