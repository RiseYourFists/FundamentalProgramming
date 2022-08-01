using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var numbersDictionary = new SortedDictionary<int, int>();

            foreach (var item in numbersInput)
            {
                if(!numbersDictionary.ContainsKey(item))
                {
                    numbersDictionary.Add(item, 1);
                    continue;
                }

                numbersDictionary[item]++;
            }

            foreach (var item in numbersDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
