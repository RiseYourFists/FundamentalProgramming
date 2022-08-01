using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[]  args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length % 2 == 0).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, input).TrimEnd());
        }
    }
}
