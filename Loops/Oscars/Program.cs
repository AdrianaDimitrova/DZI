public class Program
    {
       public static void Main(string[] args)
        {
        string name = Console.ReadLine()!;
        double points = double.Parse(Console.ReadLine()!);
        int evaluators = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < evaluators; i++)
        {
            string evaluatiorName = Console.ReadLine()!;
            double givenPoints = double.Parse(Console.ReadLine()!);
            
           double totalPoints = (evaluatiorName.Length * givenPoints)/ 2;
            points +=totalPoints;

            if(points > 1250.5)
            {
               break;
            }
        }

        if (points >1250.5)
        {
            Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:F1}!");
        }
        else
        {
            double neededPoints = Math.Abs(points - 1250.5);
            Console.WriteLine($"Sorry, {name} you need {neededPoints:F1} more!");
        }
      

        }
    }
    

