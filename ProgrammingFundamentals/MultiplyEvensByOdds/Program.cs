using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var numbers = SeparateByDigits(input);
            var sumOfOdd = 0;
            var sumOfEven = 0;

            foreach (var item in numbers)
            {
                if(item % 2 == 0)
                {
                    sumOfEven += item;
                }
                else
                {
                    sumOfOdd += item;
                }
            }

            Console.WriteLine(sumOfEven * sumOfOdd);


        }

        static int[] SeparateByDigits(int number)
        {
            var absoluteNumber = Math.Abs(number);
            var numToText = absoluteNumber.ToString();
            var result = new int[numToText.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (int)char.GetNumericValue(numToText[i]);
            }

            return result;
        }
    }
}
