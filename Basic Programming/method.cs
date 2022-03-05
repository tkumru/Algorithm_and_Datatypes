using System.Collections;

class method
{
    static void s(string[] args){
        print();
    }

    public static void print(){  // if no static, main method cant call directly print method
        System.Console.WriteLine("Printed!");
    }
}