using System;
using System.Linq;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wordSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                var synonym = Console.ReadLine();

                if(!wordSynonyms.ContainsKey(word))
                {
                    wordSynonyms.Add(word, new List<string> { synonym });
                    continue;
                }

                wordSynonyms[word].Add(synonym);
            }

            foreach (var item in wordSynonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
