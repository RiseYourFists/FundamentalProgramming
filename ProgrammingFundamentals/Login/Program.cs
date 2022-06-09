using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] key = text.ToCharArray();

            Array.Reverse(key);

            string password = new string(key);

            for (int i = 1; i <= 4; i++)
            {
                string pwInput = Console.ReadLine();

                if(pwInput != password)
                {
                    if(i < 4)
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                        continue;
                    }

                    Console.WriteLine($"User {text} blocked!");
                    break;
                }

                Console.WriteLine($"User {text} logged in.");
                break;
            }
        }
    }
}
