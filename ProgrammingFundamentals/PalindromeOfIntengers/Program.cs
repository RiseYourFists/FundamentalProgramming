using System;

namespace PalindromeOfIntengers
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            while(command != "END")
            {
                var number = int.Parse(command);
                var result = (IsNumPalindrome(number))? "true": "false";
                Console.WriteLine(result);

                command = Console.ReadLine();
            }
        }

        static bool IsNumPalindrome(int num)
        {
            string numToText = num.ToString();
            var digits = new char[numToText.Length];

            for (int i = 0; i < numToText.Length; i++)
            {
                digits[i] = numToText[i];
            }

            Array.Reverse(digits);
            var resultText = string.Concat(digits);
            var result = int.Parse(resultText);

            if(result == num)
            {
                return true;
            }

            return false;
        }
    }
}
