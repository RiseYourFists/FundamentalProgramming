using System;
using System.Numerics;
namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = times; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
