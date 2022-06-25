using System;

namespace SignOfIntNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine($"{SignOfInt(number)}");
        }

        static string SignOfInt(int number)
        {
            var result = string.Empty;

            if(number > 0)
            {
                result = $"The number {number} is positive.";
            }
            else if(number < 0)
            {
                result = $"The number {number} is negative.";
            }
            else
            {
                result = $"The number {number} is zero.";
            }

            return result;
        }
    }
}
