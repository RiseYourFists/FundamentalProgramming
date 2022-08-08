using System;

namespace LettersDigitsAndSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = string.Empty;
            var letters = string.Empty;
            var symbols = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char digit = input[i];

                if(char.IsDigit(digit))
                {
                    numbers += digit;
                    continue;
                }

                if(char.IsLetter(digit))
                {
                    letters += digit;
                    continue;
                }

                symbols += digit;
            }

            Console.WriteLine($"{numbers}\n{letters}\n{symbols}");
        }
    }
}
