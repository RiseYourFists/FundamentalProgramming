using System;
using System.Linq;
namespace StrongNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                string lenght = i.ToString();
                int currNum = i;

                for (int j = 0; j < lenght.Length; j++)
                {
                    int digit = currNum % 10;
                    sum += digit;
                    currNum /= 10;
                }

                Console.WriteLine($"{i} -> {IsStrong(sum)}");
            }
        }

        static bool IsStrong(int num)
        {
            bool result = num == 5 || num == 7 || num == 11;

            return result;
        }
    }
}
