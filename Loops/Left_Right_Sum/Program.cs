public class Program
    {
       public static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine()!);
        int leftSum = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine()!);
            leftSum += num;
        }

        int rightSum = 0;
        for (int i = 0; i < n; i++)
        {
            int num2 = int.Parse(Console.ReadLine()!);
            rightSum += num2;
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            int diff = Math.Abs(leftSum-rightSum);
            Console.WriteLine($"No, diff = {diff}");
        }
        }
    }

