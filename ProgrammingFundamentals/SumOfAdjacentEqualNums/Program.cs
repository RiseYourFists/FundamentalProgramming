using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfAdjacentEqualNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<double>();

            numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            bool hasMatches = true;
            int counter = -1;
            while (hasMatches)
            {

                counter++;

                if (counter >= (numbers.Count - 1))
                {
                    hasMatches = false;
                    continue;
                }

                if (numbers[counter] == numbers[counter + 1])
                {
                    numbers[counter] += numbers[counter + 1];
                    numbers.RemoveAt(counter + 1);
                    counter = -1;
                    continue;
                }
            }

            Console.WriteLine($"{string.Join(' ', numbers)}");
        }
    }
}
