
    public class Program
    {
       public static void Main(string[] args)
        {
         int length = int.Parse(Console.ReadLine()!);
         int width = int.Parse(Console.ReadLine()!);
         int height = int.Parse(Console.ReadLine()!);
         double procent = double.Parse(Console.ReadLine()!);

        double volume = length * width * height;
        double volumeInLiters = volume * 0.001;
        double needwater = volumeInLiters * (1 - (procent / 100));

        Console.WriteLine(needwater);
    }
    }

