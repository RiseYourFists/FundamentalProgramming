using System;

namespace ExactSumOfRealNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = 0m;

            for (int i = 0; i < n; i++)
            {
                result += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
        }
    }
}
