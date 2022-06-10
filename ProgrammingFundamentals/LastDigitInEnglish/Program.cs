using System;

namespace LastDigitInEnglish
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            int lastDigit = number.Length - 1;

            var digit = number[lastDigit];
            var text = string.Empty;

            switch(digit)
            {
                case '0':
                    text = "zero";
                    break;
                case '1':
                    text = "one";
                    break;
                case '2':
                    text = "two";
                    break;
                case '3':
                    text = "three";
                    break;
                case '4':
                    text = "four";
                    break;
                case '5':
                    text = "five";
                    break;
                case '6':
                    text = "six";
                    break;
                case '7':
                    text = "seven";
                    break;
                case '8':
                    text = "eight";
                    break;
                case '9':
                    text = "nine";
                    break;
            }

            Console.WriteLine(text);
        }
    }
}
