class Struct
{
    static void aMain(string[] args){
        var list = new List<Student>(){
            new Student(864, "Talha Nebi"),
            new Student(124, "Abcd")
        };

        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        }

        list.ForEach(o => System.Console.WriteLine(o));
    }
}