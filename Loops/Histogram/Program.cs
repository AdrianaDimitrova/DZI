public class Program
    {
        public static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine()!);
        double p1 = 0.0;
        double p2 = 0.0;
        double p3 = 0.0;
        double p4 = 0.0;
        double p5 = 0.0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine()!);

            if (number < 200)
            {
                p1++;
            }
            else if (number >= 200 && number <= 399)
            {
                p2++;
            }
            else if (number >= 400 && number <= 599)
            {
                 p3++;
            }
            else if (number >= 600 && number <= 799)
            {
                 p4++;
            }
            else
            {
                 p5++;
            }
        }

        double P1 = p1 * 100.0 / n;
        double P2 = p2 * 100.0 / n;
        double P3 = p3 * 100.0 / n;
        double P4 = p4 * 100.0 / n;
        double P5 = p5 * 100.0 / n;

        Console.WriteLine($"{P1:f2}%");
        Console.WriteLine($"{P2:f2}%");
        Console.WriteLine($"{P3:f2}%");
        Console.WriteLine($"{P4:f2}%");
        Console.WriteLine($"{P5:f2}%");
    }
    }

