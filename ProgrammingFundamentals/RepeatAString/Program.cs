using System;
using System.Text;

namespace RepeatAString
{
    class Program
    {
        static void Main(string[] args)
        {
            var @string = Console.ReadLine();
            var timesToRepeat = int.Parse(Console.ReadLine());

            var text = RepeatString(@string, timesToRepeat);
            Console.WriteLine(text);
        }

        static string RepeatString(string line, int times)
        {
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                text.Append(line);
            }
            string result = text.ToString();

            return result;
        }
    }
}
