 using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int lenght = ValidateLenght(numbers.Count);
            var result = new List<int>();

            for (int i = 0; i < lenght; i++)
            {
                result.Add(numbers[i] + numbers[(numbers.Count - 1) - i]);
            }

            if(numbers.Count % 2 == 1)
            {
                result.Add(numbers[lenght]);
            }

            Console.WriteLine($"{string.Join(' ', result)}");
        }

        private static int ValidateLenght(int lenght)
        {
            if (lenght % 2 == 0)
            {
                lenght /= 2;
            }
            else
            {
                lenght = (lenght - 1) / 2;
            }

            return lenght;
        }
    }
}
