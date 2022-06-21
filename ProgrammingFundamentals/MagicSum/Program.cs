using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                var currNum = input[i];

                for (int j = i + 1; j < input.Length; j++)
                {
                    if(currNum + input[j] == magicNumber)
                    {
                        Console.WriteLine($"{currNum} {input[j]}");
                    }
                }
            }
        }
    }
}
