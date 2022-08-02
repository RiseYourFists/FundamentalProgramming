using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Dictionary<string, long>();

            while (true)
            {
                var ore = Console.ReadLine();

                if(ore == "stop")
                {
                    break;
                }

                var amount = long.Parse(Console.ReadLine());

                if(!inventory.ContainsKey(ore))
                {
                    inventory.Add(ore, amount);
                    continue;
                }

                inventory[ore] += amount;

            }

            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
