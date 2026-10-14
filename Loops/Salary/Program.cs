public class Program
    {
       public static void Main(string[] args)
        {
        int tabs = int.Parse(Console.ReadLine()!);
        int salary = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < tabs; i++)
        {
            string app = Console.ReadLine()!;

            if (app == "Facebook")
            {
                salary -= 150;
            }
            else if (app == "Instagram")
            {
                salary -= 100;
            }
            else if (app == "Reddit")
            {
                salary -= 50;
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
                break;
            }
        }
        if (salary > 0)
        {
            Console.WriteLine(salary);
        }
    }
    }

