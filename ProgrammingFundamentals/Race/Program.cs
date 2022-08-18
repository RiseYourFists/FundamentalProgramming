using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scores = new Dictionary<string, double>();
            var racers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in racers)
            {
                scores.Add(item, 0);
            }

            while (true)
            {
                var input = Console.ReadLine();

                if(input == "end of race")
                {
                    break;
                }

                var name = GetName(input);

                if(scores.Keys.Contains(name))
                {
                    var score = GetScore(input);
                    scores[name] += score;
                }
            }

            var results = scores.OrderByDescending(x => x.Value);
            var counter = 1;
            foreach (var item in results)
            {
                if(counter == 4)
                {
                    break;
                }

                var place = string.Empty;
                switch (counter)
                {
                    case 1:
                        place = "1st";
                        break;
                    case 2:
                        place = "2nd";
                        break;
                    case 3:
                        place = "3rd";
                        break;
                }
                counter++;
                Console.WriteLine($"{place} place: {item.Key}");
            }
            
        }

        static string GetName(string line)
        {
            var result = new StringBuilder();

            foreach (var ch in line)
            {
                if(char.IsLetter(ch))
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }

        static double GetScore(string line)
        {
            double result = 0;

            foreach (var ch in line)
            {
                if(char.IsDigit(ch))
                {
                    result += char.GetNumericValue(ch);
                }
            }

            return result;
        }
    }
}
