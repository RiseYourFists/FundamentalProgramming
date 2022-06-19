using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var pokePower = long.Parse(Console.ReadLine());// N
            var initialPokePower = pokePower;
            var distance = long.Parse(Console.ReadLine()); // M
            var exhaustion = int.Parse(Console.ReadLine());// Y
            int pokes = 0;

            while(pokePower >= distance)
            {
                if(pokePower == ((double)initialPokePower / 2) && exhaustion != 0)
                {
                    pokePower /= exhaustion;
                }

                if(pokePower < distance)
                {
                    break;
                }

                pokePower -= distance;
                pokes++;
            }

            Console.WriteLine($"{pokePower}\n{pokes}");

        }
    }
}
