using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Console.WriteLine($"{SumOfDigits(input)}");
        }

        static double SumOfDigits(string input)
        {
            double result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currNum = input[i];
                result += char.GetNumericValue(currNum);
            }
            return result;
        }
    }
}
