using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var operation = Console.ReadLine();
            var firstNum = double.Parse(Console.ReadLine());
            var secondNum = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Add(firstNum, secondNum);
                    break;
                case "subtract":
                    Subtract(firstNum, secondNum);
                    break;
                case "multiply":
                    Multiply(firstNum, secondNum);
                    break;
                case "divide":
                    Divide(firstNum, secondNum);
                    break;
            }
        }

        private static void Divide(double firstNum, double secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }

        private static void Multiply(double firstNum, double secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }

        private static void Subtract(double firstNum, double secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }

        private static void Add(double firstNum, double secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
    }
}
