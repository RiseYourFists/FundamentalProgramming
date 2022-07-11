using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine();
            var result = new List<string>();

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
                    result = MergeList(data, property1, property2);
                }
                else
                {
                    result = DivideList(data, property1, property2);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', result));
            
        }

        static List<string> MergeList(List<string> collection, int startIndex, int endIndex)
        {
            var result = collection;
            var len = collection.Count;
            for (int i = 0; i < len; i++)
            {
                if (i >= startIndex && i <= endIndex - 1)
                {
                    result[i] += result[i + 1];
                    result.RemoveAt(i + 1);
                    endIndex--;
                    i--;
                    len--;
                }
            }
            return result;
        }

        static List<string> DivideList(List<string> collection, int index, int partitions)
        {
            var result = collection;
            var cell = collection[index];
            result.RemoveAt(index);
            var parts = cell.Length / partitions;
            var remainder = cell.Length % partitions;
            var ch = 0;

            for (int i = 0; i < parts; i++)
            {
                var count = 1;
                var resultCell = string.Empty;
                while (count <= partitions)
                {
                    count++;
                    resultCell += cell[ch];
                    ch++;
                }
                result.Insert(index, resultCell);
                index++;
            }
            if (remainder == 0)
            {
                return result;
            }

            var lastChars = string.Empty;

            for (int i = ch; i < ch + remainder; i++)
            {
                lastChars += cell[i];
            }
            result.Insert(index, lastChars);

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

            if (right > boundryLenght)
            {
                result[rightIndex] = $"{boundryLenght}";
            }
            return result;
        }
    }
}
