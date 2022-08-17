using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var validPhoneNumberPattern = @"(?:\+359)( |-)2\1(\d{3})\1(\d{4})\b";

            var input = Console.ReadLine();

            var regex = new Regex(validPhoneNumberPattern);
            var match = regex.Matches(input);

            var matchedPhones = match.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
