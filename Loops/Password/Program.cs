public class Program
    {
       public static void Main(string[] args)
        {
        string name = Console.ReadLine()!;
        string password = Console.ReadLine()!;
        string current = Console.ReadLine()!;

        while (current != password)
        {
            current = Console.ReadLine()!;
        }
        Console.WriteLine($"Welcome,{name}!");
        }
    }
