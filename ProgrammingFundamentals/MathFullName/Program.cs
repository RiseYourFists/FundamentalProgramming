using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var namePattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";

            Regex regex = new Regex(namePattern);
            MatchCollection match = regex.Matches(input);

            foreach (Match item in match)
            {
                Console.Write(item + " ");
            }

        }
    }
}
