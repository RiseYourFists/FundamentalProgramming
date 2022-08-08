using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var removeKey = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();

            foreach (var item in removeKey)
            {
                while (input.Contains(item))
                {
                    input = input.Replace(item, new string('*', item.Length));
                }
            }

            Console.WriteLine(input);
        }
    }
}
