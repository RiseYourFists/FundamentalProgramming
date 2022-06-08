using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var result = 0;

            if(number % 2 == 0)
            {
                result = 2;
            }
            if (number % 3 == 0)
            {
                result = 3;
            }
            if (number % 6 == 0)
            {
                result = 6;
            }
            if (number % 7 == 0)
            {
                result = 7;
            }
            if (number % 10 == 0)
            {
                result = 10;
            }

            if(result != 0)
            {
                Console.WriteLine($"The number is divisible by {result}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
