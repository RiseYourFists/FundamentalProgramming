using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var command = Console.ReadLine();

            while (command != "End")
            {
                var input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var action = input[0];

                switch (action)
                {
                    case "Add":
                        numbers.Add(int.Parse(input[1]));
                        break;
                    case"Insert":
                        if(ValidateLenght(int.Parse(input[2]), numbers))
                        {
                            numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                            command = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine("Invalid index");
                        break;
                    case "Remove":
                        if(ValidateLenght(int.Parse(input[1]), numbers))
                        {
                            numbers.RemoveAt(int.Parse(input[1]));
                            command = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine("Invalid index");
                        break;
                    case "Shift":
                        int count = int.Parse(input[2]);
                        int last = numbers.Count - 1;
                        
                        if(input[1] == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Insert(0, numbers[last]);
                                numbers.RemoveAt(last + 1);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        break;

                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));

        }

        static bool ValidateLenght(int len, List<int> collection)
        {
            if(len >= 0 && len <= collection.Count - 1)
            {
                return true;
            }
            return false;
        }
    }
}
