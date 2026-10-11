using System;

public class Program
{
    public static void Main(string[] args)
    {
       
        int examHour = int.Parse(Console.ReadLine()!);
        int examMinutes = int.Parse(Console.ReadLine()!);
        int arrivingHour = int.Parse(Console.ReadLine()!);
        int arrivingMinutes = int.Parse(Console.ReadLine()!);

        
        int examM = (examHour * 60) + examMinutes;
        int arrivingM = (arrivingHour * 60) + arrivingMinutes;

        
        int difference = examM - arrivingM;

       
        if (difference < 0)
        {
            Console.WriteLine("Late");

            
            difference = Math.Abs(difference);

            int hours = difference / 60;
            int minutes = difference % 60;

            if (hours == 0)
            {
                Console.WriteLine($"{minutes} minutes after the start");
            }
            else
            {
                
                Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
            }
        }
        
        else if (difference >= 0 && difference <= 30)
        {
            Console.WriteLine("On time");

            
            if (difference > 0)
            {
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
       
        else
        {
            Console.WriteLine("Early");

            int hours = difference / 60;
            int minutes = difference % 60;

            if (hours == 0)
            {
                Console.WriteLine($"{minutes} minutes before the start");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
            }
        }
    }
}