public class Program
    {
       public static void Main(string[] args)
        {
        int max = int.MinValue;
        string command = Console.ReadLine()!;

        while (command != "Stop")
        {
            int number = int.Parse(command);
            if (number > max)
            {
                max = number;
             
            }
            command = Console.ReadLine()!;
            
        }
        Console.WriteLine(max);
        }
    }

