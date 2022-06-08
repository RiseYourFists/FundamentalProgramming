using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfPeople = int.Parse(Console.ReadLine());

            var groupType = Console.ReadLine();

            var dayOfSettling = Console.ReadLine();

            double[,] priceList =
            {
                { 8.45, 9.80, 10.46 },
                { 10.90, 15.60, 16 },
                { 15, 20, 22.50 }
            };

            int iDay = 0;
            int iGroup = 0;

            switch (dayOfSettling)
            {
                case "Friday":
                    iDay = 0;
                    break;
                case "Saturday":
                    iDay = 1;
                    break;
                case "Sunday":
                    iDay = 2;
                    break;
            }

            double discount = 0;
            int freeStay = 0;

            switch (groupType)
            {
                case "Students":
                    iGroup = 0;
                    if(countOfPeople >= 30)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Business":
                    iGroup = 1;
                    if(countOfPeople >= 100)
                    {
                        freeStay = 10;
                    }
                    break;
                case"Regular":
                    iGroup = 2;
                    if(countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        discount = 0.05;
                    }
                    break;
            }

            double sum = priceList[iGroup, iDay] * (countOfPeople - freeStay);
            double result = sum - (sum * discount);

            Console.WriteLine($"Total price: {result:f2}");
        }
    }
}
