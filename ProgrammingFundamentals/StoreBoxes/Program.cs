using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Box(int serialNumber, string itemName, int itemQuantity, double boxPrice)
        {
            SerialNumber = serialNumber;
            ItemName = itemName;
            ItemQuantity = itemQuantity;
            BoxPrice = boxPrice;
        }

        public int SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public double BoxPrice { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var Items = new List<Item>();
            var Boxes = new List<Box>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var serialNumber = int.Parse(tokens[0]);
                var itemName = tokens[1];
                var quantity = int.Parse(tokens[2]);
                var itemPrice = double.Parse(tokens[3]);
                var boxPrice = quantity * itemPrice;

                var newItem = new Item(itemName, itemPrice);
                var newBox = new Box(serialNumber, itemName, quantity, boxPrice);

                Items.Add(newItem);
                Boxes.Add(newBox);


                input = Console.ReadLine();
            }

            Boxes = Boxes.OrderByDescending(x => x.BoxPrice).ToList();
            foreach (var item in Boxes)
            {
                int priceIndex = Items.FindIndex(x => x.Name == item.ItemName);
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.ItemName} - ${Items[priceIndex].Price:f2}: {item.ItemQuantity}");
                Console.WriteLine($"-- ${item.BoxPrice:f2}");
            }
        }
    }
}
