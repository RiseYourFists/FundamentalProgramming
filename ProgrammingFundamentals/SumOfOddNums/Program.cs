using System;

namespace SumOfOddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            n *= 2;

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
