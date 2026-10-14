using System.Diagnostics.CodeAnalysis;

public class Program
    {
        public static void Main(string[] args)
        {
        string text = Console.ReadLine()!;
        int sum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char current = text[i];

            if (current == 'a')
            {
                sum += 1;
            }
            else if (current == 'e')
            {
                sum += 2;
            }
            else if (current == 'i')
            {
                sum += 3;
            }
            else if (current == 'o')
            {
                sum += 4;
            }
            else if (current == 'u')
            {
                sum += 5;
            }
        }
        Console.WriteLine(sum);
        }
    }
