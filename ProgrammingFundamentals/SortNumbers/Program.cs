using System;
using System.Collections.Generic;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sortedNumbers.Add(number);
            }

            sortedNumbers.Sort();
            sortedNumbers.Reverse();

            foreach (var item in sortedNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
