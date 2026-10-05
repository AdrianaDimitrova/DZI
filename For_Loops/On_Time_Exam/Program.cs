namespace On_Time_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine()!);
            int examMinute = int.Parse(Console.ReadLine()!);
            int arrivalHour = int.Parse(Console.ReadLine()!);
            int arrivalMinute = int.Parse(Console.ReadLine()!);

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;

            int diff = arrivalTime - examTime;

            if (diff > 0)
            {
                Console.WriteLine("Late");
            }

            else if (diff >= -30)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Early");
            }

            if (diff != 0)
            {
                int absDiff = Math.Abs(diff);
                int hours = absDiff / 60;
                int minutes = absDiff % 60;

                string suffix = "";

                if (diff > 0)
                {
                    suffix = "after the start";
                }
                else
                {
                    suffix = "before the start";
                }

                if (absDiff < 60)
                {
                    Console.WriteLine($"{minutes} minutes {suffix}");
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours {suffix}");
                }

            }      



        }
    }
}
