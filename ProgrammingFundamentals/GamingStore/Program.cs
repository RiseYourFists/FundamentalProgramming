using System;
using System.Collections.Generic;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceList = new Dictionary<string, double>()
            {
                {"OutFall 4",39.99 },
                {"CS: OG", 15.99 },
                {"Honored 2", 59.99 },
                {"Zplinter Zell", 19.99 },
                {"RoverWatch", 29.99},
                {"RoverWatch Origins Edition", 39.99 }
            };

            double spendings = 0;

            var balance = double.Parse(Console.ReadLine());

            var command = Console.ReadLine();

            while (command != "Game Time")
            {

                if (priceList.ContainsKey(command))
                {
                    priceList.TryGetValue(command, out double price);

                    if(price > balance)
                    {
                        Console.WriteLine("Too Expensive");
                        command = Console.ReadLine();
                        continue;
                    }

                    Console.WriteLine($"Bought {command}");
                    balance -= price;
                    spendings += price;
                    
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                command = Console.ReadLine();

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }

            if(balance > 0)
            {
                Console.WriteLine($"Total spent: ${Math.Round(spendings, 2):F2}. Remaining: ${Math.Round(balance, 2):f2}");
            }
            
        }
    }
}
