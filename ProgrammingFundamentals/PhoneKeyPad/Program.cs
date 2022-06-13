using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneKeyPad
{
    class Program
    {
        static void Main(string[] args)
        {

            var keyPad = new Dictionary<string, List<char>>()
            {
                {"2", new List<char>(AddKey("a b c")) },
                {"3", new List<char>(AddKey("d e f")) },
                {"4", new List<char>(AddKey("g h i")) },
                {"5", new List<char>(AddKey("j k l")) },
                {"6", new List<char>(AddKey("m n o")) },
                {"7", new List<char>(AddKey("p q r s")) },
                {"8", new List<char>(AddKey("t u v")) },
                {"9", new List<char>(AddKey("w x y z")) },
                {"0", new List<char>(){' '} }
            };

            var n = int.Parse(Console.ReadLine());
            var text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                string digit = input[0].ToString();
                int letter = input.Length - 1;

                keyPad.TryGetValue(digit, out List<char> pressed);
                text += pressed[letter];
            }

            Console.WriteLine(text);

            
        }

        static List<char> AddKey(string chars)
        {
            var key = chars.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToList();
            return key;
        }

    }
}
