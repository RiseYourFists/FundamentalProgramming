using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            var result = Pow(number, pow);

            Console.WriteLine(result);
        }

        private static double Pow(double number, int pow)
        {
            var result = number;
            
            for (int i = 1; i <= pow - 1; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
