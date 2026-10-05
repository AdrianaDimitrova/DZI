
    public class Program
    {
        public static void Main(string[] args)
        {
        int points = int.Parse(Console.ReadLine()!);
        double bonus = 0.0;

        if (points <= 100)
        {
            bonus = 5;
        }
        else if (points > 1000)
        {
            bonus = points * 0.10;
        }

        else
        {
            bonus = points * 0.20;
        }

        if (points % 2 == 0)
        {
            bonus++;
        }

        if (points % 5 == 0)
        {
            bonus += 2;
        }

        }
    }

