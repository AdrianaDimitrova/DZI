public class Program
    {
       public static void Main(string[] args)
        {
        int min = int.MaxValue;
        string comm = Console.ReadLine()!;

        while (comm != "Stop")
        {
            int number = int.Parse(comm);

            if (number < min)
            {
                min = number;

            }
            comm = Console.ReadLine()!;
        }
        Console.WriteLine(min);
        }
    }

