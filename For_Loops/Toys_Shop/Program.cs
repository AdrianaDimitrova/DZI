
using System.Security.Cryptography;

public class Program
    {
       public static void Main(string[] args)
        {
        double excursion = double.Parse(Console.ReadLine()!);
        int puzzles = int.Parse(Console.ReadLine()!);
        int dolls = int.Parse(Console.ReadLine()!);
        int bears = int.Parse(Console.ReadLine()!);
        int minions = int.Parse(Console.ReadLine()!);
        int trucks = int.Parse(Console.ReadLine()!);

        int totalToys = puzzles + dolls + bears + minions + trucks;
        double totalSum = (puzzles * 2.60) + (dolls * 3.00) + (bears * 4.10) + (minions * 8.20) + (trucks * 2.00);

        if (totalToys >= 50)
        {
            totalSum *= 0.75;
        }

        totalSum *= 0.90;

        if (totalSum >= excursion)
        {
            Console.WriteLine($"Yes! {(totalSum - excursion):f2} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {(excursion - totalSum):f2} lv needed.");
        }
        }
    }

