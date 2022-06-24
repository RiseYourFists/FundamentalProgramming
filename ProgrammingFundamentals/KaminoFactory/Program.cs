using System;
using System.Collections.Generic;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var dnaLenght = int.Parse(Console.ReadLine());

            var DNA = new string[dnaLenght];
            var longest = -1;
            var longestPos = -1;
            var test = -1;
            var counter = 0;

            var input = Console.ReadLine();

            while (input != "Clone them!")
            {
                counter++;
                var dataDNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries);

                var testDna = new List<int>(LongestLenghtAtPos(string.Concat(dataDNA),'1'));

                if(testDna[0] >= longest)
                {
                    if(testDna[0] == longest)
                    {
                        if(testDna[1] < longestPos)
                        {
                            longest = testDna[0];
                            longestPos = testDna[1];
                            DNA = dataDNA;
                            test = counter;
                        }
                        else if(testDna[1] == longestPos)
                        {
                            var currSum = SumOfArray(dataDNA);
                            var sumOfBiggest = SumOfArray(DNA);

                            if(currSum > sumOfBiggest)
                            {
                                longest = testDna[0];
                                longestPos = testDna[1];
                                DNA = dataDNA;
                                test = counter;
                            }
                        }

                        input = Console.ReadLine();
                        continue;
                    }

                    longest = testDna[0];
                    longestPos = testDna[1];
                    DNA = dataDNA;
                    test = counter;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {test} with sum: {SumOfArray(DNA)}.\n{string.Join(' ', DNA)}");
        }

        static List<int> LongestLenghtAtPos(string lineToSearch, char target)
        {
            var result = new List<int>();
            var biggest = 0;
            var pos = 0;

            for (int i = 0; i < lineToSearch.Length; i++)
            {
                var currCheck = lineToSearch[i];
                if(currCheck != target)
                {
                    continue;
                }

                if (lineToSearch.Length - i < biggest)
                {
                    break;
                }

                var lenght = 0;

                for (int j = i; j < lineToSearch.Length; j++)
                {

                    if(target == lineToSearch[j])
                    {
                        lenght++;
                        continue;
                    }

                    break;

                }

                if(lenght >= biggest)
                {
                    biggest = lenght;
                    pos = i;

                }
            }

            result.Add(biggest);
            result.Add(pos);

            return result;
        }
        static int SumOfArray(string[] collection)
        {
            var result = 0;

            var numbers = collection.Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            return result;
        }
    }
}
