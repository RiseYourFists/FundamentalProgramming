using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> vMachine = new Dictionary<string, double>()
            {
                {"Nuts", 2.0 },
                {"Water", 0.7 },
                {"Crisps", 1.5 },
                {"Soda", 0.8 },
                {"Coke", 1.0 }
            };

            string command = Console.ReadLine();
            double balance = 0;
            while(command != "Start")
            {
                double coin = double.Parse(command);

                switch(coin)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        balance += coin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;

                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while(command != "End")
            {
                if(!vMachine.ContainsKey(command))
                {
                    Console.WriteLine("Invalid product");
                    command = Console.ReadLine();
                    continue;
                }

                vMachine.TryGetValue(command, out double price);

                if (price > balance)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased {command.ToLower()}");
                    balance -= price;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}
