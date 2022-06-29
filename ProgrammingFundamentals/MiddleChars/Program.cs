using System;

namespace MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var middleChars = MiddleChars(text);
            Console.WriteLine(middleChars);
        }

        static string MiddleChars(string text)
        {
            var result = string.Empty;

            if(text.Length % 2 == 0)
            {
                var len = (text.Length / 2) - 1;
                result = string.Concat(text[len], text[len + 1]);
            }
            else
            {
                var len = text.Length / 2;
                result = text[len].ToString();
            }

            return result;
        }
    }
}
