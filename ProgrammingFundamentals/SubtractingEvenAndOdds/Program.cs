using System;
using System.Linq;

namespace SubtractingEvenAndOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var rawInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var evenNums = rawInput.Select(item =>
            {
                if (item % 2 == 0)
                    return item;
                return 0;
            })
            .ToArray();

            var oddNums = rawInput.Select(item =>
            {
                if (item % 2 == 1)
                    return item;
                return 0;
            })
            .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            foreach (var item in evenNums)
            {
                evenSum += item;
            }

            foreach (var item in oddNums)
            {
                oddSum += item;
            }

            int result = evenSum - oddSum;

            Console.WriteLine(result);
        }
    }
}
