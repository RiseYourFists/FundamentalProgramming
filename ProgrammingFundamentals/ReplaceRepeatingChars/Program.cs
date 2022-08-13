using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                ReplaceRepeatingChar(ref input, input[i], i);
            }

            Console.WriteLine(input);
        }

        static void ReplaceRepeatingChar(ref string line, char target, int startIndex)
        {
            var count = 0;
            for (int i = startIndex; i < line.Length; i++)
            {
                if(line[i] == target)
                {
                    count++;
                    continue;
                }
                break;
            }

            line = line.Remove(startIndex, count);
            line = line.Insert(startIndex, target.ToString());
        }
    }
}
