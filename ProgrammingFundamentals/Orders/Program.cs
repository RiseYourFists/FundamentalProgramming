using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 0; i < orders; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());

                double cost = price * (days * capsules);
                Console.WriteLine($"The price for coffee is: ${cost:f2}");
                total += cost;
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
