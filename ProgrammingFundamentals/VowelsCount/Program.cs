using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            int vowels = Vowels(text.ToLower());
            Console.WriteLine(vowels);
        }

        static int Vowels(string text)
        {
            int vowels = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                switch(letter)
                {
                    case 'a':
                        vowels++;
                        break;
                    case 'o':
                        vowels++;
                        break;
                    case 'u':
                        vowels++;
                        break;
                    case 'e':
                        vowels++;
                        break;
                    case 'i':
                        vowels++;
                        break;
                }
            }

            return vowels;
        }
    }
}
