using System;
using System.Numerics;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var kegsAmount = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            var maxName = string.Empty;
            for (int i = 0; i < kegsAmount; i++)
            {
                string model = Console.ReadLine();
                var radius = decimal.Parse(Console.ReadLine());
                var height = BigInteger.Parse(Console.ReadLine());

                decimal PI =(decimal)( Math.PI);
                BigInteger result = (BigInteger)(PI * (radius * radius) * (decimal)height);

                if(result > maxValue)
                {
                    maxValue = result;
                    maxName = model;
                }
            }

            Console.WriteLine(maxName);
        }
    }
}
