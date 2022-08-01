using System;
using System.Collections.Generic;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var bitNumber = ConvertToBinary(number);
            var compare = Console.Read();
            var matches = 0;

            for (int i = 0; i < bitNumber.Length; i++)
            {
                if(bitNumber[i] == compare)
                {
                    matches++;
                }
            }

            Console.WriteLine(matches);

        }

        static string ConvertToBinary(int number)
        {
            var convertedNumber = new List<int>();

            while(number > 0)
            {
                convertedNumber.Add(number % 2);
                number /= 2;
            }
            convertedNumber.Reverse();

            return string.Join("",convertedNumber);
        }
    }
}
