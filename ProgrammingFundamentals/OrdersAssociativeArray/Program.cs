using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class LegendaryItem
    {
        public LegendaryItem(string name, string materials, int amount)
        {
            Name = name;
            CraftingItem = materials;
            CraftingItemAmount = amount;
        }
        public string Name { get; set; }
        public string CraftingItem { get; set; }
        public int CraftingItemAmount { get; set; }
    }

    class LegendaryItemList
    {
        public LegendaryItemList()
        {
            LegendaryItems = new List<LegendaryItem>();
            InitialItems();
        }
        public List<LegendaryItem> LegendaryItems { get; set; }

        public void InitialItems()
        {
            LegendaryItems.Add(new LegendaryItem("Shadowmourne", "shards", 250));
            LegendaryItems.Add(new LegendaryItem("Valanyr", "fragments", 250));
            LegendaryItems.Add(new LegendaryItem("Dragonwrath", "motes", 250));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var legendaryItems = new LegendaryItemList();
            var garbageStache = new Dictionary<string, int>();
            var importantMaterials = new Dictionary<string, int>();
            importantMaterials.Add("shards", 0);
            importantMaterials.Add("motes", 0);
            importantMaterials.Add("fragments", 0);

            var farmedItems = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToList();

            for (int i = 1; i < farmedItems.Count; i += 2)
            {
                var itemName = farmedItems[i];
                var amount = int.Parse(farmedItems[i - 1]);
                
                if(importantMaterials.ContainsKey(itemName))
                {
                    importantMaterials[itemName] += amount;
                    continue;
                }

                VerifyAndAdd(garbageStache, itemName, amount);

            }

            foreach (var item in importantMaterials)
            {
                if (legendaryItems.LegendaryItems.Any(x => x.CraftingItem == item.Key && x.CraftingItemAmount <= item.Value))
                {
                    var legendaryItem = legendaryItems.LegendaryItems.Find(x => x.CraftingItem == item.Key);
                    Console.WriteLine($"{legendaryItem.Name} obtained!");
                    importantMaterials[item.Key] -= legendaryItem.CraftingItemAmount;

                }
            }

            foreach (var item in importantMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in garbageStache)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }

        private static void VerifyAndAdd(Dictionary<string, int> collection, string itemName, int amount)
        {
            if (!collection.ContainsKey(itemName))
            {
                collection.Add(itemName, amount);
                return;
            }

            collection[itemName] += amount;
            
        }
    }
}
