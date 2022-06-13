using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var pounds = double.Parse(Console.ReadLine());
            var dollars = pounds * 1.31;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
