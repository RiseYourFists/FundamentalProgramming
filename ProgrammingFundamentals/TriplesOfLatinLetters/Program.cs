using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            char startingPoint = 'a';
            char endPoint = (char)(startingPoint + n - 1);

            for (int firstRow = startingPoint; firstRow <= endPoint; firstRow++)
            {
                for (int secondRow = startingPoint; secondRow <= endPoint; secondRow++)
                {
                    for (int thirdRow = startingPoint; thirdRow <= endPoint; thirdRow++)
                    {
                        Console.WriteLine($"{(char)firstRow}{(char)secondRow}{(char)thirdRow}");
                    }
                }
            }
        }
    }
}
