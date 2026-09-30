   public class Program
  {
     public static void Main(string[] args)
      {
        int nailon = int.Parse(Console.ReadLine()!);
        int paint = int.Parse(Console.ReadLine()!);
        int razreditel = int.Parse(Console.ReadLine()!);
        int hours = int.Parse(Console.ReadLine()!);

        double nailonPrice = (nailon + 2) * 1.50;
        double paintPrice = (paint + paint * 0.1) * 14.50;
        double razreditelPrice = razreditel * 5.00;
        double totalPrice = nailonPrice + paintPrice + razreditelPrice + 0.40;
        double workersPrice = (totalPrice * 0.30) * hours;
        double finalPrice = totalPrice + workersPrice;

        Console.WriteLine(finalPrice);



    }
  }

