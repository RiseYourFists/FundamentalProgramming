using System;

namespace CodeRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            int currentNumber = 0;


            for (int i = 1; i <= number; i++)
            {

                bool isSpecial = false;

                currentNumber = i;

                while (currentNumber > 0)
                {

                    sum += currentNumber % 10;

                    currentNumber /= 10;

                }

                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", i, isSpecial);

                sum = 0;

            }
        }
    }
}
