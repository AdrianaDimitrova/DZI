
   public class Program
    {
       public static void Main(string[] args)
        {
          int trainingTax = int.Parse(Console.ReadLine()!);
          
        double basketballShoesPrice = trainingTax * 0.6;
        double basketballClothesPrice = basketballShoesPrice * 0.8;
        double basketballBallPrice = basketballClothesPrice / 4;
        double basketballAccessoriesPrice = basketballBallPrice / 5;

        double totalPrice = trainingTax + basketballShoesPrice + basketballClothesPrice + basketballBallPrice + basketballAccessoriesPrice;

        Console.WriteLine(totalPrice);

    }
    }

