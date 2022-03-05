class Condition
{
    static void con(string[] args){
        Console.WriteLine("Number: ");

        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0){
            Console.WriteLine("Even number");
        }

        else
        {
            System.Console.WriteLine("Odd number");
        }
    }
}