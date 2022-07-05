using System;
using System.Linq;

namespace Train01
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var capacity = int.Parse(Console.ReadLine());
            var command = Console.ReadLine();

            while(command != "end")
            {
                var input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if(input[0] == "Add")
                {
                    wagons.Add(int.Parse(input[1]));
                    command = Console.ReadLine();
                    continue;
                }

                int passingers = int.Parse(input[0]);
                for (int i = 0; i < wagons.Count; i++)
                {
                    if(passingers <= capacity - wagons[i])
                    {
                        wagons[i] += passingers;
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
