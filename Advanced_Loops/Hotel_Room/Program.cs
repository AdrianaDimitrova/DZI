public class Program
    {
       public static void Main(string[] args)
        {
        string month = Console.ReadLine()!;
        int nights = int.Parse(Console.ReadLine()!);
        string place = string.Empty;
        double studioPrice = 0.0;
        double apartmentPrice = 0.0;

        switch (month)
        {
            case "May":
            case "October":
                studioPrice = 50.0;
                apartmentPrice = 65.0;
                if (nights > 14)
                {
                    studioPrice *= 0.70;
                }
                else if (nights > 7)
                {
                    studioPrice *= 0.95;
                }
                break;


            case "June":
            case "September":
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                if (nights > 14)
                {
                    studioPrice *= 0.80;
                }
                break;


            case "July":
            case "August":
                studioPrice = 76.0;
                apartmentPrice = 77.0;
                break;
        }

        if (nights > 14)
        {
            apartmentPrice *= 0.90;
        }

        double totalApartment = nights * apartmentPrice;
        double totalStudio = nights * studioPrice;

        Console.WriteLine($"Apartment: {totalApartment:f2} euro.");
        Console.WriteLine($"Studio: {totalStudio:f2} euro.");
        }
    }
