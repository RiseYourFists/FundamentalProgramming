using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charHolder = new char [3];

            for (int i = 0; i < charHolder.Length; i++)
            {
                charHolder[i] = char.Parse(Console.ReadLine());
            }

            Array.Reverse(charHolder);

            foreach (var item in charHolder)
            {
                Console.Write(item + " ");
            }
        }
    }
}
