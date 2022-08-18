using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Purchase
    {
        public Purchase(string itemName, double price, int quantity)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
        }

        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var shoppingList = new List<Purchase>();
            var input = Console.ReadLine();
            var purchasePattern = @">>([A-z\s]+)<<([0-9]+\.[0-9]+|[0-9]+)!([0-9]+)";
            var regex = new Regex(purchasePattern);

            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    var itemName = match.Groups[1].Value;
                    var price = double.Parse(match.Groups[2].Value);
                    var quantity = int.Parse(match.Groups[3].Value);
                    if(quantity <= 0)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    shoppingList.Add(new Purchase(itemName, price, quantity));
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Bought furniture:");
            foreach (var item in shoppingList)
            {
                Console.WriteLine(item.ItemName);
            }
            CalcPrice(shoppingList);
        }

        static void CalcPrice(List<Purchase> collection)
        {
            var total = 0d;

            foreach (var item in collection)
            {
                total += item.Price * item.Quantity;
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
