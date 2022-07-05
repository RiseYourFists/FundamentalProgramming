using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var command = Console.ReadLine();
            bool hasChanges = false;
            while (command != "end")
            {
                var input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var action = input[0];

                switch (action)
                {
                    case "Contains":
                        if (numbers.Contains(int.Parse(input[1])))
                        {
                            Console.WriteLine("Yes");
                            break;
                        }
                        Console.WriteLine("No such number");
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(' ', numbers.FindAll(x => x % 2 == 1)));
                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(' ', numbers.FindAll(x => x % 2 == 0)));
                        break;

                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;

                    case "Filter":
                        FilterList(numbers, input[1], int.Parse(input[2]));
                        break;

                    case "Add":
                        numbers.Add(int.Parse(input[1]));
                        hasChanges = true;
                        break;

                    case "Remove":
                        numbers.Remove(int.Parse(input[1]));
                        hasChanges = true;
                        break;

                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(input[1]));
                        hasChanges = true;
                        break;

                    case "Insert":
                        numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        hasChanges = true;
                        break;

                }

                command = Console.ReadLine();
            }

            if(hasChanges)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }

        static void FilterList(List<int> collection, string condition, int startingNumber)
        {
            switch (condition)
            {
                case ">":
                    Console.WriteLine(string.Join(' ', collection.FindAll(x => x > startingNumber)));
                    break;
                case "<":
                    Console.WriteLine(string.Join(' ', collection.FindAll(x => x < startingNumber)));
                    break;
                case ">=":
                    Console.WriteLine(string.Join(' ', collection.FindAll(x => x >= startingNumber)));
                    break;
                case "<=":
                    Console.WriteLine(string.Join(' ', collection.FindAll(x => x <= startingNumber)));
                    break;
            }
        }
    }
}
