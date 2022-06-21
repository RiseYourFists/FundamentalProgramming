using System;
using System.Linq;

namespace TopIntengers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var result = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currNum = numbers[i];
                bool isGreater = true;

                if(i == numbers.Length - 1)
                {
                    result += currNum;
                    break;
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if(!(currNum > numbers[j]))
                    {
                        isGreater = false;
                        break;
                    }
                }

                if(isGreater)
                {
                    result += currNum + " ";
                }

            }

            Console.WriteLine(result);
        }
    }
}
