 public class Program
    {
       public static void Main(string[] args)
        {
        double budget = double.Parse(Console.ReadLine()!);
        int statists = int.Parse(Console.ReadLine()!);
        double statistClothes = double.Parse(Console.ReadLine()!);

        double decorPrice = budget * 0.10;
        double totalClothes = statists * statistClothes;

        if (statists > 150)
        {
            totalClothes *= 0.90;
        }

        double totalExpences = totalClothes + decorPrice;

        if (totalExpences > budget)
        {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {Math.Abs(totalExpences - budget):f2} leva more.");

        }

        else
        {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {Math.Abs(budget - totalExpences):f2} leva left.");
        }
        }
    }
