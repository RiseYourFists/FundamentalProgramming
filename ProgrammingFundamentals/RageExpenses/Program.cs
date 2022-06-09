using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lostGames = int.Parse(Console.ReadLine());
            var priceHeadset = double.Parse(Console.ReadLine());
            var priceMouse = double.Parse(Console.ReadLine());
            var priceKeyboard = double.Parse(Console.ReadLine());
            var priceDisplay = double.Parse(Console.ReadLine());

            int brokenHeadsets = lostGames / 2;
            int brokenMouse = lostGames / 3;

            int brokenKeyboard = 0;

            for(int i = 1; i <= lostGames; i++)
            {
                if(i % 2 == 0 && i % 3 == 0)
                {
                    brokenKeyboard++;
                }
            }

            int brokenDisplay = brokenKeyboard / 2;

            double costHeadset = brokenHeadsets * priceHeadset;
            double costMouse = brokenMouse * priceMouse;
            double costKeyboard = brokenKeyboard * priceKeyboard;
            double costDisplay = brokenDisplay * priceDisplay;

            double totalDamage = costDisplay + costHeadset + costKeyboard + costMouse;

            Console.WriteLine($"Rage expenses: {totalDamage:f2} lv.");
        }
    }
}
