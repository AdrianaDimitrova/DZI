
using System.Threading.Channels;

public class Program
    {
       public static void Main(string[] args)
        {
        string figure = Console.ReadLine()!;

        switch (figure)
        {
            case "square":
                double a = double.Parse(Console.ReadLine()!);
                double sSquare = a * a;
                Console.WriteLine($"{sSquare:f3}");
                break;

            case "rectangle":
                double b = double.Parse(Console.ReadLine()!);
                double c = double.Parse(Console.ReadLine()!);
                double sRec = b * c;
                Console.WriteLine($"{sRec:f3}");
                break;

            case "circle":
                double r = double.Parse(Console.ReadLine()!);
                double sCircle = r * r * Math.PI;
                Console.WriteLine($"{sCircle:f3}");
                break;

            case "triangle":
                double d = double.Parse(Console.ReadLine()!);
                double h = double.Parse(Console.ReadLine()!);
                double sTriangle = (d * h) / 2;
                Console.WriteLine($"{sTriangle:f3}");
                break;

        }

        }
    }

