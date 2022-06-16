using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int waterTankCapacity = 255;
            int tankFull = 0;
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var waterIntake = int.Parse(Console.ReadLine());

                if(tankFull + waterIntake > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                tankFull += waterIntake;
            }

            Console.WriteLine(tankFull);
        }
    }
}
