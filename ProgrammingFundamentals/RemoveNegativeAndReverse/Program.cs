using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            numbers.RemoveAll(x => x < 0);
            numbers.Reverse();
            if(numbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            Console.WriteLine($"{string.Join(' ', numbers)}");
        }
    }
}
