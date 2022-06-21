using System;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                var tempArray = new string[text.Length];
                for (int j = 0; j < tempArray.Length - 1; j++)
                {
                    tempArray[j] = text[j + 1];
                }

                tempArray[tempArray.Length - 1] = text[0];

                text = tempArray;
            }

            Console.WriteLine($"{string.Join(' ', text)}");
        }
    }
}
