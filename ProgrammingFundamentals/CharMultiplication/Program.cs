using System;

namespace CharMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var firstValue = input[0];
            var secondValue = input[1];
            var total = 0;
            var multiplyCicles = GetLowerLen(firstValue, secondValue);

            for (int i = 0; i < multiplyCicles; i++)
            {
                var multiplicationResult = MultiplyCharValues(firstValue[i], secondValue[i]);
                total += multiplicationResult;
            }

            var longest = GetLongestLen(firstValue, secondValue);

            if(longest != null)
            {
                var remainder = GetRemainder(longest, multiplyCicles);
                total += remainder;
            }

            Console.WriteLine(total);
        }

        public static int GetLowerLen(string firstString, string secondString)
        {
            var strOneLen = firstString.Length;
            var strTwoLen = secondString.Length;

            if(strOneLen < strTwoLen)
            {
                return strOneLen;
            }

            return strTwoLen;
        }

        public static string GetLongestLen(string firstString, string secondString)
        {
            var strOneLen = firstString.Length;
            var strTwoLen = secondString.Length;

            if(strOneLen == strTwoLen)
            {
                return null;
            }

            if (strOneLen < strTwoLen)
            {
                return secondString;
            }


            return firstString;
        }

        public static int MultiplyCharValues(char firstChar, char secondChar)
        {
            return firstChar * secondChar;
        }

        public static int GetRemainder(string remainingChars, int skipTo)
        {
            int result = 0;

            for (int i = skipTo; i < remainingChars.Length; i++)
            {
                result += remainingChars[i];
            }

            return result;
        }
    }
}
