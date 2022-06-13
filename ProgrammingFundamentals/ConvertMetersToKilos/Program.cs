using System;

namespace ConvertMetersToKilos
{
    class Program
    {
        static void Main(string[] args)
        {
            var meter = int.Parse(Console.ReadLine());

            double kilometer = (double)meter / 1000;

            Console.WriteLine($"{kilometer:f2}");
        }
    }
}
