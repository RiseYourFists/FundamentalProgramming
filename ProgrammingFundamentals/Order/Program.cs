using System;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var total = TotalPrice(product, quantity);
            Console.WriteLine($"{Math.Round(total, 2):f2}");
        }

        static double TotalPrice(string product, int amount)
        {
            double result;

            var price = 0d;

            switch(product)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2;
                    break;
            }

            result = price * amount;

            return result;
        }
    }
}
