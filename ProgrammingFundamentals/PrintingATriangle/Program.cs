using System;

namespace PrintingATriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                PrintLine(i);
            }
            for (int i = size - 1; i > 0; i--)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int len)
        {
            for (int i = 1; i <= len; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
