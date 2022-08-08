using System;

namespace ReverseText
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }

                var ch = input.ToCharArray();
                Array.Reverse(ch);
                var reversed = new string(ch);

                Console.WriteLine($"{input} = {reversed}");
                
            }
        }
    }
}
