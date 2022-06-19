using System;
using System.Linq;

namespace ArrayCondensation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int operations = input.Length - 1;

            for (int i = 0; i < operations; i++)
            {
                var temp2 = new int[input.Length - 1];

                for (int j = 0; j < temp2.Length; j++)
                {
                    temp2[j] = input[j] + input[j + 1];
                }

                input = temp2;
            }

            Console.WriteLine(input[0]);
        }
    }
}
