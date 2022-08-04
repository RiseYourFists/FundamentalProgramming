using System;
using System.Collections.Generic;

namespace OrdersAssociativeArrays
{
    class Item
    {
        public Item(string itemName, double price, int amount)
        {
            Name = itemName;
            Price = price;
            Amount = amount;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
    }

    class ShoppingList
    {
        public ShoppingList()
        {
            MyList = new Dictionary<string, Item>();
        }
        public Dictionary<string, Item> MyList { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingList();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var itemName = tokens[0];
                var price = double.Parse(tokens[1]);
                var amount = int.Parse(tokens[2]);

                VerifyAndAdd(cart, itemName, amount, price);
            }

            foreach (var item in cart.MyList)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value.Price * item.Value.Amount):f2}");
            }
        }

        private static void VerifyAndAdd(ShoppingList collection, string itemName, int amount, double price)
        {
            if (!collection.MyList.ContainsKey(itemName))
            {
                collection.MyList.Add(itemName, new Item(itemName, price, amount));
                return;
            }

            collection.MyList[itemName].Amount += amount;
            collection.MyList[itemName].Price = price;

        }
    }
}
