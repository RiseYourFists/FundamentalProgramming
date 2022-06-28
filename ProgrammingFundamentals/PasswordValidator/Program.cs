using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            bool lenghtTest = HasGoodLen(input);
            bool enoughDigits = HasEnoughDigits(input);
            bool onlyDigitsAndNums = IsOnlyDigitsAndNums(input);
            bool isValid = true;

            if(!lenghtTest)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (!onlyDigitsAndNums)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!enoughDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if(isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool HasGoodLen(string password)
        {
            if(password.Length >= 6 && password.Length <= 10 )
            {
                return true;
            }

            return false;
        }

        static bool HasEnoughDigits(string password)
        {
            int digitCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char currChar = password[i];

                if(currChar >= 48 && currChar <= 57)
                {
                    digitCounter++;
                }
            }

            if(digitCounter >= 2)
            {
                return true;
            }

            return false;
        }

        static bool IsOnlyDigitsAndNums(string password)
        {

            for (int i = 0; i < password.Length; i++)
            {
                char currChar = password[i];

                if(currChar >= 48 && currChar <= 57)
                {
                    continue;
                }

                if(currChar >= 65 && currChar <= 90)
                {
                    continue;
                }

                if(currChar >= 97 && currChar <= 122)
                {
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
