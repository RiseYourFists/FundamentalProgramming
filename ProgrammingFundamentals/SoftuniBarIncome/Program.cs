using System;
using System.Text.RegularExpressions;

namespace SoftuniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerNamePattern = @"%([A-Z][a-z]+)%";
            var productNamePattern = @"<(\w+)>";
            var productAmountPattern = @"\|([0-9]+)\|";
            var productPricePattern = @"([0-9]+\.*[0-9]*)\$";
            var totalIncome = 0d;

            while (true)
            {
                var input = Console.ReadLine();

                if(input == "end of shift")
                {
                    break;
                }

                var customerName = Regex.Match(input, customerNamePattern);
                if(!customerName.Success)
                {
                    continue;
                }

                var productName = Regex.Match(input, productNamePattern);

                if(!productName.Success)
                {
                    continue;
                }

                var productAmount = Regex.Match(input, productAmountPattern);

                if(!productAmount.Success)
                {
                    continue;
                }

                var productPrice = Regex.Match(input, productPricePattern);

                if(!productPrice.Success)
                {
                    continue;
                }
                var amount = int.Parse(productAmount.Groups[1].Value);
                var price = double.Parse(productPrice.Groups[1].Value);

                var accumulatedSum = amount * price;
                Console.WriteLine($"{customerName.Groups[1].Value}: {productName.Groups[1].Value} - {accumulatedSum:f2}");
                totalIncome += accumulatedSum;
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
