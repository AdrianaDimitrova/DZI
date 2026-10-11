public class Program
    {
       public static void Main(string[] args)
        {
        string city = Console.ReadLine()!;
        double sales = double.Parse(Console.ReadLine()!);
        double comm = 0.0;

        if (sales < 0)
        {
            Console.WriteLine("error");
            return;
        }
        switch (city)
        {
            case "Sofia":
                if (sales >= 0 && sales <= 500)
                {
                    comm = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comm = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comm = sales * 0.08;
                }
                else
                {
                    comm = sales * 0.12;
                }
                break;

            case "Varna":
                if (sales >= 0 && sales <= 500)
                {
                    comm = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comm = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comm = sales * 0.10;
                }
                else
                {
                    comm = sales * 0.13;
                }
                break;

            case "Plovdiv":
                if (sales >= 0 && sales <= 500)
                {
                    comm = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comm = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comm = sales * 0.12;
                }
                else
                {
                    comm = sales * 0.145;
                }
                break;

            default:
                Console.WriteLine("error");
                return;
        }
        Console.WriteLine($"{comm:f2}");
       }
    }

