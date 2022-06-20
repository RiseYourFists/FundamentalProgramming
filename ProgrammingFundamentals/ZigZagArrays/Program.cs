using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var pairs = int.Parse(Console.ReadLine());

            var numbers = new int[pairs * 2];

            for (int i = 0; i < numbers.Length; i += 2)
            {
                var tempHolder = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < tempHolder.Length; j++)
                {
                    numbers[i + j] = tempHolder[j];
                }
            }

            bool firstColumn = true;
            string column1 = string.Empty;
            string column2 = string.Empty;
            int counter = -1;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (firstColumn)
                {
                    column1 += numbers[i] + " ";
                    if(counter == -1)
                    {
                        firstColumn = false;
                    }
                }
                else
                {
                    column2 += numbers[i] + " ";
                }

                counter++;

                if(counter == 2)
                {
                    if(firstColumn)
                    {
                        firstColumn = false;
                    }
                    else
                    {
                        firstColumn = true;
                    }

                    counter = 0;
                }
            }

            Console.WriteLine($"{column1}\n{column2}");
        }
    }
}
