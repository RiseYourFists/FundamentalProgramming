using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var validDatePattern = @"(\d{2})(/|-|.)([A-Z][a-z]{2})\2(\d{4})\b";

            var input = Console.ReadLine();
            var match = Regex.Matches(input, validDatePattern);

            foreach (Match item in match)
            {
                Console.WriteLine($"Day: {item.Groups[1]}, Month: {item.Groups[3]}, Year: {item.Groups[4]}");
            }
        }
    }
}
