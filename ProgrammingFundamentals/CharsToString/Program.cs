using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = new char[3];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = char.Parse(Console.ReadLine());
            }

            string result = new string(input);

            Console.WriteLine(result);
        }
    }
}
