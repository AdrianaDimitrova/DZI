public class Program
{
    public static void Main(string[] args)
    {
        double salary = double.Parse(Console.ReadLine()!);
        double averageGrade = double.Parse(Console.ReadLine()!);
        double minimalSalary = double.Parse(Console.ReadLine()!);

        double socialScholarship = 0.0;
        double excellentScholarship = 0.0;

        if (salary < minimalSalary && averageGrade > 4.50)
        {
            socialScholarship = Math.Floor(0.35 * minimalSalary);
        }

        if (averageGrade >= 5.50)
        {
            excellentScholarship = Math.Floor(25 * averageGrade);
        }

        if (socialScholarship == 0 && excellentScholarship == 0)
        {
            Console.WriteLine("You cannot get a scholarship!");
        }
        else if (excellentScholarship >= socialScholarship)
        {
            Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} EU");
        }
        else
        {
            Console.WriteLine($"You get a Social scholarship {socialScholarship} EU");
        }
    }
}

