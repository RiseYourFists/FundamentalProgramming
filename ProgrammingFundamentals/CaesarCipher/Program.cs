using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = Encrypt(input);
            Console.WriteLine(result);
        }

        static string Encrypt(string line)
        {
            var result = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                var currCh = line[i];
                var push = (char)(currCh + 3);
                result.Append(push);
            }
            return result.ToString();
        }
    }
}
