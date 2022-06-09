using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string factorialNumber = Console.ReadLine();

            int result = 0;

            for (int i = 0; i < factorialNumber.Length; i++)
            {
                int number = (int)Char.GetNumericValue(factorialNumber[i]);
                
                result += Factorial(number);
            }

            string comparisson = result.ToString();

            if(comparisson == factorialNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static int Factorial(int num)
        {
            int result = num;

            for (int i = num - 1; i >= 1; i--)
            {
                result *= i;
            }

            if(result == 0)
            {
                result = 1;
            }

            return result;
        }
    }
}
