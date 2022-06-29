using System;

namespace FactorialDevision
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = double.Parse(Console.ReadLine());
            var numTwo = double.Parse(Console.ReadLine());

            var factorialOne = Factorial(numOne);
            var factorialTwo = Factorial(numTwo);

            var result = factorialOne / factorialTwo;
            Console.WriteLine($"{result:f2}");
        }

        static double Factorial(double num)
        {
            double result = num;

            for (double i = num - 1; i >= 1; i--)
            {
                result *= i;
            }
            
            if (result < 1)
            {
                result = 1;
            }

            return result;
        }
    }
}
