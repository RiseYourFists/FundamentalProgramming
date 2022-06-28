using System;

namespace ASCIIMethodInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var valueOne = char.Parse(Console.ReadLine());
            var ValueTwo = char.Parse(Console.ReadLine());

            int firstChar = valueOne;
            int secondChar = ValueTwo;

            if(firstChar < secondChar)
            {
                ASCIIinRange(valueOne, ValueTwo);
            }
            else
            {
                ASCIIinRange(ValueTwo, valueOne);
            }
        }

        static void ASCIIinRange(char start, char end)
        {
            for (int i = start + 1; i < end; i++)
            {
                char currChar = (char)i;

                Console.Write($"{currChar} ");
            }
        }
    }
}
