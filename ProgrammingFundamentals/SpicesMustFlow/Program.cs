 using System;

namespace SpicesMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialYield = long.Parse(Console.ReadLine());

            long profit = 0;
            var dayCounter = 0;

            while(initialYield >= 100)
            {
                dayCounter++;
                profit += initialYield - 26;
                initialYield -= 10;
            }

            if(profit > 0)
            {
                Console.WriteLine($"{dayCounter}\n{profit - 26}");
                return;
            }
                Console.WriteLine($"{dayCounter}\n{profit}");
        }
    }
}
