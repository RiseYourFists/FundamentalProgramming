using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var lineOne = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var lineTwo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var mergeLenght = ShorterLenght(lineOne, lineTwo);
            var result = new List<int>();

            for (int i = 0; i < mergeLenght; i++)
            {
                result.Add(lineOne[i]);
                result.Add(lineTwo[i]);
            }

            int remainder = LongerLenght(lineOne, lineTwo);
            var remainderList = LargerList(lineOne, lineTwo);

            for (int i = mergeLenght; i < remainder; i++)
            {
                result.Add(remainderList[i]); 
            }

            Console.WriteLine($"{string.Join(' ', result)}");

        }

        static int ShorterLenght(List<int> lineOne, List<int> lineTwo)
        {
            if( lineOne.Count < lineTwo.Count)
            {
                return lineOne.Count;
            }

            return lineTwo.Count;
        }

        static int LongerLenght(List<int> lineOne, List<int> lineTwo)
        {
            if (lineOne.Count > lineTwo.Count)
            {
                return lineOne.Count;
            }

            return lineTwo.Count;
        }

        static List<int> LargerList(List<int> lineOne, List<int> lineTwo)
        {
            if(lineOne.Count > lineTwo.Count)
            {
                return lineOne;
            }

            return lineTwo;
        }

    }
}
