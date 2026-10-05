public class Program
   {
    public static void Main(string[] args)
    {
        string series = Console.ReadLine()!;
        int episodeDuration = int.Parse(Console.ReadLine()!);
        int breakDuration = int.Parse(Console.ReadLine()!);

        double lunchBreak = breakDuration / 8.0;
        double rest = breakDuration / 4.0;

        double freeTime = breakDuration - lunchBreak - rest;

        if (episodeDuration <= freeTime)
        {
            double extraTime = freeTime - episodeDuration;
            Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(extraTime)} minutes free time.");
        }
        else
        {
            double neededTime = episodeDuration - freeTime;
            Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(neededTime)} more minutes.");
        }

    }
    }

