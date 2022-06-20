using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var checkingInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var toCheck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < toCheck.Length; i++)
            {
                var element = toCheck[i];

                for (int j = 0; j < checkingInput.Length; j++)
                {
                    if(checkingInput[j] == element)
                    {
                        Console.Write($"{element} ");
                    }
                }
            }
        }
    }
}
