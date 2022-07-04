using System;
using System.Linq;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var command = Console.ReadLine();
            while (command != "end")
            {
                var input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var action = input[0];

                switch (action)
                {
                    case "Add":
                        numbers.Add(int.Parse(input[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(input[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(input[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{string.Join(' ', numbers)}");
        }
    }
}
