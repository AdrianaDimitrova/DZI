public class Program
   {
       public static void Main(string[] args)
       {
        int days = int.Parse(Console.ReadLine()!);
        string place = Console.ReadLine()!;
        string rate = Console.ReadLine()!;

        int nights = days - 1;
        double price = 0.0;

        switch (place)
        {
            case "room for one person":
                price = nights * 18.00;
                break;


            case "apartment":
                if (days < 10)
                {
                    price = 25.00 * 0.70* nights;
                }

                else if (days >= 10 && days <= 15)
                {
                    price = 25.00 * 0.65 * nights;
                }

                else
                {
                    price = 25.00 * 0.50 * nights;
                } 
                break;

            case "president apartment":
                if (days < 10)
                {
                    price = 35.00 * 0.90 * nights;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = 35.00 * 0.85 * nights;
                }
                else
                {
                    price = 35.00 * 0.80 * nights;
                }
                break;
        }

        if (rate == "positive")
        {
            price *= 1.25;
        }
        else
        {
            price *= 0.90;
        }
        Console.WriteLine($"{price:f2}");
    }
   }
