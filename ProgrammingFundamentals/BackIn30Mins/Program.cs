using System;

namespace BackIn30Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins += 30;

            if(mins > 59)
            {
                mins -= 60;
                hour++;
            }

            if(hour >= 24)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{mins:d2}");
        }
    }
}
