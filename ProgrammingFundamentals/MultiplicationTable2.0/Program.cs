using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var rotations = int.Parse(Console.ReadLine());
            var moreThan10 = rotations > 10;

            for (int i = rotations; i <= 10 ; i++)
            {
                var result = number * i;
                Console.WriteLine($"{number} X {i} = {result}");
            }

            if(moreThan10)
            {
                Console.WriteLine($"{number} X {rotations} = {rotations * number}");
            }
        }
    }
}
