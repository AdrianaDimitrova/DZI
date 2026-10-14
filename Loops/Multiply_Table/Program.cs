public class Program
    {
       public static void Main(string[] args)
        {
        for (int num = 1; num <= 10; num++)
        {
            for (int num2 = 1; num2 <= 10; num2++)
            {
                int result = num * num2;
                Console.WriteLine($"{num} * {num2} = {result}");
            }
        }
        }
    }
