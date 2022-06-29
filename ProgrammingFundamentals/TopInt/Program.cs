using System;
using System.Linq;
namespace TopInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int[] digits = SeparateByDigits(i);
                int sumOfDigits = digits.Sum();

                if (!IsDivisibleBy(sumOfDigits, 8))
                {
                    continue;
                }

                if(!HasOddNum(digits))
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        static bool IsDivisibleBy(int num, int division)
        {
            if(num % division == 0)
            {
                return true;
            }

            return false;
        }

        static int[] SeparateByDigits(int num)
        {
            string line = num.ToString();
            char[] nonConvDigits = new char[line.Length];

            for (int i = 0; i < nonConvDigits.Length; i++)
            {
                nonConvDigits[i] = line[i];
            }

            int[] result = new int[nonConvDigits.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = nonConvDigits[i];
            }

            return result;
        }

        static bool HasOddNum(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
