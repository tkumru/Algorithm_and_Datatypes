class Multidimensionarray
{
    static void asdasd(string[] args){

        Console.WriteLine("Dimensions: ");
        int dimension = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[dimension];
        var random = new Random();


        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 10); // random number 1-10
        }

        foreach (int item in numbers)
        {
            System.Console.Write(item + ",");
        }
        System.Console.WriteLine();

        double[,] matris = new double[,]
        {
            {1,2,3},
            {2,3,4},
            {3,4,5}
        };

        for (int i = 0; i < matris.GetLength(0); i++)
        {
            for (int j = 0; j < matris.GetLength(1); j++)
            {
                System.Console.Write($"{matris[i,j], 3}");
            }

            System.Console.WriteLine();
        }
    }
}