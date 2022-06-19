using System;
using System.Linq;

namespace SumOfEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenNums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Select( x => { if (x % 2 == 0) return x; return 0; }).ToArray();

            int sum = 0;

            for (int i = 0; i < evenNums.Length; i++)
            {
                sum += evenNums[i];
            }

            Console.WriteLine(sum);


        }
    }
}
