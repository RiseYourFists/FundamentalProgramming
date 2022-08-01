using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();

            var OccuranceList = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if(!OccuranceList.ContainsKey(item))
                {
                    OccuranceList.Add(item, 1);
                    continue;
                }

                OccuranceList[item]++;
            }

            var result = OccuranceList.Where(x => x.Value % 2 == 1);

            foreach (var item in result)
            {
                Console.Write($"{item.Key} ");
            }
        }
    }
}
