public class Program
    {
       public static void Main(string[] args)
        {
        int tournirs = int.Parse(Console.ReadLine()!);
        int startPoints = int.Parse(Console.ReadLine()!);

        int seasonPoints = 0;
        int winsCount = 0;

        for (int i = 0; i < tournirs; i++)
        {
            string type = Console.ReadLine()!;


            if (type == "W")
            {
                seasonPoints += 2000;
                winsCount++;
            }
            else if (type == "F")
            {
                seasonPoints += 1200;
            }
            else if (type == "SF")
            {
                seasonPoints += 720;
            }

        }
        int totalPoints = startPoints + seasonPoints;
        double averagePoints = seasonPoints / tournirs;
        double winsPercent = (winsCount * 100.0) / tournirs;

        Console.WriteLine($"Final points: {totalPoints}");
        Console.WriteLine($"Average points: {averagePoints}");
        Console.WriteLine($"{winsPercent:f2}%");
    }
    }
