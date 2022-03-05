class value_reference
{
    static void Main(string[] args){
        int x = 1, y =2;

        System.Console.WriteLine("First main method printed: ");
        System.Console.WriteLine("{0}, {1}", x, y);

        setValue(x, y);

        System.Console.WriteLine("Second main method printed: ");
        System.Console.WriteLine("{0}, {1}", x, y);

        setValueRef(ref x, ref y);

        System.Console.WriteLine("Third main method printed: ");
        System.Console.WriteLine("{0}, {1}", x, y);
    }

    private static void setValue(int x, int y){
        int temp = x;
        x = y;
        y = temp;
        System.Console.WriteLine("In method printed: ");
        System.Console.WriteLine("{0}, {1}", x, y);
    }

    private static void setValueRef(ref int x, ref int y){
    int temp = x;
    x = y;
    y = temp;
    System.Console.WriteLine("In reference method printed: ");
    System.Console.WriteLine("{0}, {1}", x, y);
    }
}