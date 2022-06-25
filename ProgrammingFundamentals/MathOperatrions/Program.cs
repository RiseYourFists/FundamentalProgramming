using System;

namespace MathOperatrions
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var operation = char.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var result = 0;

            switch (operation)
            {
                case '+':
                    result = Add(firstNum, secondNum);
                    break;
                case '-':
                    result = Subtract(firstNum, secondNum);
                    break;
                case '*':
                    result = Multiply(firstNum, secondNum);
                    break;
                case '/':
                    result = Divide(firstNum, secondNum);
                    break;
            }

            Console.WriteLine(result);
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
