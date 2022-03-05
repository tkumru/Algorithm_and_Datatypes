class Strings
{
    static void array(string[] args){
        string s = "Hello World!";

        Console.WriteLine(s);
        Console.WriteLine(s.Length);
        Console.WriteLine(s.ToUpper());
        Console.WriteLine(s.ToLower());
        Console.WriteLine(s.TrimStart());
        Console.WriteLine(s.TrimEnd());
        Console.WriteLine(s[0]);
    }
}