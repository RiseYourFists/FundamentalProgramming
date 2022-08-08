using System;
using System.Text;

namespace RepeatingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var sb = new StringBuilder();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    sb.Append(item);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
