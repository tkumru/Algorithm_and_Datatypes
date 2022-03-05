class For
{
    static void dasd(string[] args){
        Console.WriteLine("Number: ");

        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            System.Console.WriteLine(i);
        }
    }
}