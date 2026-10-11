public class Program
    {
       public static void Main(string[] args)
        {
        string typeFlowers = Console.ReadLine()!;
        int countFlowers = int.Parse(Console.ReadLine()!);
        int budget = int.Parse(Console.ReadLine()!);

        double price = 0.0;

        switch (typeFlowers)
        {
            case "Roses":
                price = 5.00 * countFlowers;

                if (countFlowers > 80)
                {
                    price *= 0.90;
                }
                break;

            case "Dahlias":
                price = 3.80 * countFlowers;

                if (countFlowers > 90)
                {
                    price *= 0.85;
                }
                break;

            case "Tulips":
                price = 2.80 * countFlowers;

                if (countFlowers > 80)
                {
                    price *= 0.85;
                }
                break;

            case "Narcissus":
                price = 3.00 * countFlowers;

                if (countFlowers < 120)
                {
                    price *= 1.15;
                }
                break;

            case "Gladiolus":
                price = 2.50 * countFlowers;

                if (countFlowers < 80)
                {
                    price *= 1.20;
                }
                break;

        }

        if (budget > price)
        {
            double moneyLeft = budget - price;
            Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {moneyLeft:f2} leva left.");
        }
        else
        {
            double neededMoney = price - budget;
            Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
        }

        }
    }
