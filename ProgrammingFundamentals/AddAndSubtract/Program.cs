using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var firstOperation = Add(numbers[0], numbers[1]);
            var lastOperation = Subtract(firstOperation, numbers[2]);
            Console.WriteLine(lastOperation);

        }

        static int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        static int Subtract(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
    }
}
