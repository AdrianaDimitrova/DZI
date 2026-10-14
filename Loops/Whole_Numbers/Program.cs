public class Program
    {
       public static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine()!);
        int max = int.MinValue;
        int min = int.MaxValue;

        while (n > 0)
        {
            int num = int.Parse(Console.ReadLine()!);

            if (num > max)
            {
                max = num;
            }

            if (num < min)
            {
                min = num;
            }

            n--;
        }
        Console.WriteLine($"Max number:{max}");
        Console.WriteLine($"Min number:{min}");
        }
    }

