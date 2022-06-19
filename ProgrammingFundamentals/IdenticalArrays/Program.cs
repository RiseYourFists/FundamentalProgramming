using System;
using System.Linq;

namespace IdenticalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var Array1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var Array2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var sum = 0;

            for (int i = 0; i < Array1.Length; i++)
            {
                if(Array1[i] == Array2[i])
                {
                    sum += Array1[i];
                    continue;
                }

                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                return;
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
