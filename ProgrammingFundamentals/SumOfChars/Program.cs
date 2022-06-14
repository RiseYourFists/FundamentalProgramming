using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                char asciiNum = char.Parse(Console.ReadLine());

                sum += asciiNum;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
