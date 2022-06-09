using System;

namespace PadwanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());

            var countOfStudents = int.Parse(Console.ReadLine());

            var lightsaberPrice = double.Parse(Console.ReadLine());

            var robesPrice = double.Parse(Console.ReadLine());
             
            var beltsPrice = double.Parse(Console.ReadLine());

            var beltCount = countOfStudents - (countOfStudents / 6);

            double amountOfLightsabers = Math.Ceiling(countOfStudents + (countOfStudents * 0.1));

            double sum = (countOfStudents * robesPrice) + (beltCount * beltsPrice) + (amountOfLightsabers * lightsaberPrice);

            if(sum <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {Math.Round(sum,2):f2}lv.");
            }
            else
            {
                double neededMoney = sum - budget;
                Console.WriteLine($" John will need {Math.Round(neededMoney,2):f2}lv more.");
            }
        }
    }
}
