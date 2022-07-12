using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine();
            var result = data;

            while (command != "3:1")
            {
                var input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "merge")
                {
                    input = ValidateBoundry(data, input, 1, 2);
                }
                var property1 = int.Parse(input[1]);
                var property2 = int.Parse(input[2]);

                if (input[0] == "merge")
                {
                    result = MergeList(result, property1, property2);
                }
                else
                {
                    result = DivideList(result, property1, property2);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', result));
            
        }

        static List<string> MergeList(List<string> collection, int startIndex, int endIndex)
        {
            var result = collection;
            StringBuilder merged = new StringBuilder();
            var len = endIndex - (startIndex - 1);

            for (int i = startIndex; i <= endIndex; i++)
            {
                merged.Append(collection[i]);
            }

            result.RemoveRange(startIndex, len);
            result.Insert(startIndex, merged.ToString());
            return result;
        }

        static List<string> DivideList(List<string> collection, int index, int partitions) 
        {
            var result = collection;
            if(partitions <= 0)
            {
                return result;
            }

            var cell = collection[index];

            if(partitions > cell.Length)
            {
                partitions = cell.Length;
            }

            result.RemoveAt(index);
            var parts = cell.Length / partitions;
            var remainder = cell.Length % partitions;
            var ch = 0;

            for (int i = 0; i < partitions; i++)
            {
                var currPart = string.Empty;

                for (int counter = 0; counter < parts; counter++)
                {
                    currPart += cell[ch];
                    ch++;
                }

                result.Insert(index, currPart);
                index++;
            }

            if (remainder == 0)
            {
                return result;
            }

            var lastChars = result[index - 1];
            result.RemoveAt(index - 1);

            for (int i = ch; i < ch + remainder; i++)
            {
                lastChars += cell[i];
            }
            result.Insert(index - 1, lastChars);

            return result;
        }

        static string[] ValidateBoundry(List<string> comparisson, string[] collection, int leftIndex, int rightIndex)
        {
            var result = collection;
            var boundryLenght = comparisson.Count - 1;
            var left = int.Parse(collection[leftIndex]);
            var right = int.Parse(collection[rightIndex]);
            if (left < 0)
            {
                result[leftIndex] = "0";
            }
            else if(left > boundryLenght)
            {
                result[leftIndex] = $"{boundryLenght}";
            }

            if (right > boundryLenght)
            {
                result[rightIndex] = $"{boundryLenght}";
            }
            else if(right < 0)
            {
                result[rightIndex] = "0";
            }
            return result;
        }
    }
}
