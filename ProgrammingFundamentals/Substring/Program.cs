using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var removeKey = Console.ReadLine();
            var input = Console.ReadLine();

            while (input.Contains(removeKey))
            {
                 input = input.Replace(removeKey, "");
            }

            Console.WriteLine(input);
        }
    }
}
