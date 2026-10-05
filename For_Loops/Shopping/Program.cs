 public class Program
   {
      public static void Main(string[] args)
       {
        double budget = double.Parse(Console.ReadLine()!);
        int videocards = int.Parse(Console.ReadLine()!);
        int processors = int.Parse(Console.ReadLine()!);
        int RAM = int.Parse(Console.ReadLine()!);

        double videocardPrice = videocards * 250;
        double processorPrice = videocardPrice * 0.35 * processors;
        double RAMPrice = videocardPrice * 0.10 * RAM;
        double totalPrice = videocardPrice + processorPrice + RAMPrice;

        if (videocards > processors)
        {
            totalPrice *= 0.85;
        }

        if (budget >= totalPrice)
        {
            double moneyLeft = budget - totalPrice;
            Console.WriteLine($"You have {moneyLeft:f2} leva left!");
        }
        else
        {
            double neededMoney = totalPrice - budget;
            Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva more!");
        }
    }
   }

