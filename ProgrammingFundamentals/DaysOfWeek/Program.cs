using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayNum = int.Parse(Console.ReadLine());

            var week = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if(dayNum >= 1 && dayNum <= week.Length )
            {
                Console.WriteLine($"{week[dayNum - 1]}");
                return;
            }

            Console.WriteLine("Invalid day!");
        }
    }
}
