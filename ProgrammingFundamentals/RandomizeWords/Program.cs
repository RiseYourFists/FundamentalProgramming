using System;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Random randomNum = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int index = randomNum.Next(0, input.Length - 1);
                string tempString = input[i];
                input[i] = input[index];
                input[index] = tempString;
            }

            Console.WriteLine(string.Join(Environment.NewLine , input));
        }
    }
}
