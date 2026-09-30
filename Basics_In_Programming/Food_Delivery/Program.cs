public class Program
   {
     public static void Main(string[] args)
       {
        int chickenMenu = int.Parse(Console.ReadLine()!);
        int fishMenu = int.Parse(Console.ReadLine()!);
        int vegetarianMenu = int.Parse(Console.ReadLine()!);

        double chickenMenuPrice = chickenMenu * 10.35;
        double fishMenuPrice = fishMenu * 12.40;
        double vegetarianMenuPrice = vegetarianMenu * 8.15;

        double totalPrice = chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice;
        double dessertPrice = totalPrice * 0.20;
        double finalPrice = totalPrice + dessertPrice + 2.50;

        Console.WriteLine(finalPrice);
    }
   }
