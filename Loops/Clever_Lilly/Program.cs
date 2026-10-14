public class Program
    {
       public static void Main(string[] args)
        {
        int age = int.Parse(Console.ReadLine()!);
        double washingPrice = double.Parse(Console.ReadLine()!);
        int toyPrice = int.Parse(Console.ReadLine()!);

        int toyCount = 0;
        int totalMoney = 0;
        int currentGiftMoney = 10;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                totalMoney += currentGiftMoney;
                totalMoney -=1;
                currentGiftMoney += 10;
            }
            else
            {
                toyCount++;
            }
        }
        totalMoney += toyCount * toyPrice;

        if (totalMoney >= washingPrice)
        {
            double diff = totalMoney - washingPrice;
            Console.WriteLine($"Yes! {diff:f2}");
        }
        else
        {
            double diff = washingPrice - totalMoney;
            Console.WriteLine($"No! {diff:f2}");

        }
    }
    }

