using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = new string[3];

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Console.ReadLine();
            }

            Console.WriteLine($"{text[0]}{text[2]}{text[1]}");
        }
    }
}
