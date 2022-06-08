using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var rotations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rotations; i++)
            {
                var result = number * i;
                Console.WriteLine($"{number} X {i} = {result}");
            }
        }
    }
}
