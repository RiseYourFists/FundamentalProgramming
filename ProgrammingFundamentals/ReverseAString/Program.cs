using System;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(text);
            Console.WriteLine($"{string.Join(' ',text)}");
        }
    }
}
