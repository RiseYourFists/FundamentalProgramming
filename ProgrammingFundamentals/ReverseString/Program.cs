using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            char[] textArray = text.ToCharArray();

            Array.Reverse(textArray);

            string reversedText = new string(textArray);

            Console.WriteLine(reversedText);
        }
    }
}
