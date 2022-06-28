using System;

namespace SmallestOfThreeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var threeNumbers = new int[3];

            for (int i = 0; i < threeNumbers.Length; i++)
            {
                threeNumbers[i] = int.Parse(Console.ReadLine());
            }

            var lowestNumber = Lowest(threeNumbers);

            Console.WriteLine(lowestNumber);
        }

        static int Lowest(int[] numbers)
        {
            int lowest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if(currNum < lowest)
                {
                    lowest = currNum;
                }
            }

            return lowest;
        }
    }
}
