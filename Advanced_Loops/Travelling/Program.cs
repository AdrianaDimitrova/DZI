public class Program
    {
       public static void Main(string[] args)
        {
        double budget = double.Parse(Console.ReadLine()!);
        string season = Console.ReadLine()!;
        string destination = string.Empty;
        string place = string.Empty;

        double price = 0.0;

        switch (season)
        {
            case "summer":
                place = "Camp";

                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    price = budget * 0.30;
                }
                else if (budget <= 1000)
                {
                    destination = "Balkans";
                    price = budget * 0.40;
                }
                else
                {
                    destination = "Europe";
                    place = "Hotel";
                    price = budget * 0.90;
                }
                break;

            case "winter":
                place = "Hotel";
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    price = budget * 0.70;
                }
                else if (budget <= 1000)
                {
                    destination = "Balkans";
                    price = budget * 0.80;
                }
                else
                {
                    destination = "Europe";
                    place = "Hotel";
                    price = budget * 0.90;
                }
                break;

            default:
                price = budget * 0.90;
                break;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{place} – {price:f2}");

    }
    }

