using System;
using System.Linq;

namespace PrintNumsInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = int.Parse(Console.ReadLine());

            int[] numbers = new int[inputs];

            for (int i = 0; i < inputs; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numbers);

            Console.WriteLine($"{string.Join(' ',numbers)}");
        }
    }
}
