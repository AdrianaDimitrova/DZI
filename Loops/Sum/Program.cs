public class Program
    {
       public static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine()!);

        int sum = 0;

        while (sum < n)
        {
            int current = int.Parse(Console.ReadLine()!);
            sum += current;

        }
        Console.WriteLine(sum);
        }
    }

