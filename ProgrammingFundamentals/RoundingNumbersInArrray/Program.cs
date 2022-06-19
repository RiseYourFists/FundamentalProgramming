using System;
using System.Linq;

namespace RoundingNumbersInArrray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersToRound = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double[] roundedNums = numbersToRound.Select(x => Math.Round(x, MidpointRounding.AwayFromZero)).Select(x => { if (x == -0) { x = 0;} return x; }).ToArray();

            for (int i = 0; i < roundedNums.Length; i++)
            {
                Console.WriteLine($"{numbersToRound[i]} => {roundedNums[i]}");
            }
        }
    }
}
