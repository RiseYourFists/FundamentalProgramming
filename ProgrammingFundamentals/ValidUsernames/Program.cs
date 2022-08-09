using System;
using System.Collections.Generic;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var validUsernames = new List<string>();
            foreach (var item in input)
            {
                if (!ValidateLenght(item))
                {
                    continue;
                }

                if(!ValidateChars(item))
                {
                    continue;
                }

                validUsernames.Add(item);

            }

            foreach (var item in validUsernames)
            {
                Console.WriteLine(item);
            }
        }

        public static bool ValidateLenght(string username)
        {
            return username.Length >= 3 && username.Length <= 16;
        }

        public static bool ValidateChars(string username)
        {
            for (int i = 0; i < username.Length; i++)
            {
                var currChar = username[i];

                if (char.IsDigit(currChar) || char.IsLetter(currChar) || currChar == '-' || currChar == '_')
                {
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
