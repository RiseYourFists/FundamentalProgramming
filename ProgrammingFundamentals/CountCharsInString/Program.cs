using System;
using System.Collections.Generic;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var occurances = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var currChar = input[i].ToString();

                if(currChar == " ")
                {
                    continue;
                }

                if(!occurances.ContainsKey(currChar))
                {
                    occurances.Add(currChar, 1);
                    continue;
                }

                occurances[currChar]++;
            }

            foreach (var item in occurances)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
