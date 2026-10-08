public class Program
{
    public static void Main(string[] args)
    {
        int budget = int.Parse(Console.ReadLine()!);
        string season = Console.ReadLine()!;
        int fishmen = int.Parse(Console.ReadLine()!);

        double price = 0.0;
        double rent = 0.0;

        switch (season)
        {
            case "Spring":
                rent = 3000;

                if (fishmen <= 6)
                {
                    price = rent * 0.90;
                }

                else if (fishmen >= 7 && fishmen <= 11)
                {
                    price = rent * 0.85;
                }
                else
                {
                    price = rent * 0.75;
                }

                break;


            case "Summer":
                rent = 4200;

                if (fishmen <= 6)
                {
                    price = rent * 0.90;
                }

                else if (fishmen >= 7 && fishmen <= 11)
                {
                    price = rent * 0.85;
                }
                else
                {
                    price = rent * 0.75;
                }
                break;

            case "Autumn":
                rent = 4200;

                if (fishmen <= 6)
                {
                    price = rent * 0.90;
                }

                else if (fishmen >= 7 && fishmen <= 11)
                {
                    price = rent * 0.85;
                }
                else
                {
                    price = rent * 0.75;
                }
                break;

            case "Winter":
                rent = 2600;

                if (fishmen <= 6)
                {
                    price = rent * 0.90;
                }

                else if (fishmen >= 7 && fishmen <= 11)
                {
                    price = rent * 0.85;
                }
                else
                {
                    price = rent * 0.75;
                }
                break;
        }

        if (fishmen % 2 == 0 && season != "Autumn")
        {
            price *= 0.95;
        }

        if (budget >= price)
        {
            double moneyLeft = budget - price;
            Console.WriteLine($"Yes! You have {moneyLeft:f2} euro left.");
        }
        else if (budget < price)
        {
            double neededMoney = price - budget;
            Console.WriteLine($"Not enough money! You need {neededMoney:f2} euro.");
        }
    }
}
