using System;

namespace TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] ticketPriceWeek =
            {
                { 12, 18, 12 } ,
                { 15, 20, 15 },
                { 5, 12, 10 }
            };

            var weekState = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());

            var isValidAge = true;
            int iAge = 0;

            if(age >= 0 && age <= 18)
            {
                iAge = 0;
            }
            else if(age > 18 && age <=64)
            {
                iAge = 1;
            }
            else if(age > 64 && age <= 122)
            {
                iAge = 2;
            }
            else
            {
                isValidAge = false;
                Console.WriteLine("Error!");
            }

            int iWeek = 0;

            switch (weekState)
            {
                case"weekday":
                    iWeek = 0;
                    break;
                case "weekend":
                    iWeek = 1;
                    break;
                case"holiday":
                    iWeek = 2;
                    break;
            }

            if(isValidAge)
            {
                double price = ticketPriceWeek[iWeek, iAge];
                Console.WriteLine($"{price}$");
            }
        }
    }
}
