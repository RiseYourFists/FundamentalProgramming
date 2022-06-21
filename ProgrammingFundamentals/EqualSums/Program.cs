using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if(input.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            bool noResult = true;

            for (int i = 0; i < input.Length; i++)
            {
                var leftCopyLen = i;
                var leftSide = new int[i];
                Array.Copy(input, 0, leftSide, 0, leftCopyLen);
                var sumLeft = SumOfArray(leftSide);

                var rightCopyLen = input.Length - (i + 1);
                var rightSide = new int[rightCopyLen];
                Array.Copy(input, i + 1, rightSide, 0, rightCopyLen);
                var sumRight = SumOfArray(rightSide);

                if(sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    noResult = false;
                    break;
                }
            }

            if(noResult)
            {
                Console.WriteLine("no");
            }
        }

        static int SumOfArray (int[] input)
        {
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];
            }

            return result;
        }
    }
}
