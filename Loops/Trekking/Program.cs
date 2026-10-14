public class Program
    {
       public static void Main(string[] args)
        {
        int groups = int.Parse(Console.ReadLine()!);
        double Mulala = 0.0;
        double Monblan = 0.0;
        double Kilimanjaro = 0.0;
        double K2 = 0.0;
        double Everest = 0.0;

        double totalPeople = 0;
        for (int i = 0; i < groups; i++)
        {
            int people = int.Parse(Console.ReadLine()!);
            totalPeople += people;

            if (people <= 5)
            {
                Mulala+= people;
            }
            else if (people >= 6 && people <= 12)
            {
                Monblan += people;
            }
            else if (people >= 13 && people <= 25)
            {
                Kilimanjaro += people;
            }
            else if (people >= 26 && people <= 40)
            {
                K2+=people;
            }
            else if (people >= 41)
            {
                Everest += people;
            }
        }

        Console.WriteLine($"{(Mulala / totalPeople * 100):F2}%");
        Console.WriteLine($"{(Monblan / totalPeople * 100):F2}%");        
        Console.WriteLine($"{(Kilimanjaro / totalPeople * 100):F2}%");
        Console.WriteLine($"{(K2 / totalPeople * 100):F2}%"); 
        Console.WriteLine($"{(Everest / totalPeople * 100):F2}%");
    }
    }

