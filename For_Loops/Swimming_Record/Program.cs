 public class Program
    {
      public  static void Main(string[] args)
        {
        double record = double.Parse(Console.ReadLine()!);
        double meters = double.Parse(Console.ReadLine()!);
        double time = double.Parse(Console.ReadLine()!);

        double swimming = meters * time;

        double delaysCount = Math.Floor(meters / 15);
        double time15Sec = delaysCount * 12.5;

        double totalTime = swimming + time15Sec;
            
        if (totalTime >= record)
        {
            double neededSeconds = totalTime - record;
            Console.WriteLine($"No, he failed! He was {neededSeconds:f2} seconds slower.");
        }
        else
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
        }
    }
    }

