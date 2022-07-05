using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var action = input[0];

                switch (action)
                {
                    case "Delete":
                        number.RemoveAll(x => x == int.Parse(input[1]));
                        break;
                    case "Insert":
                        number.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', number));
        }
    }
}
