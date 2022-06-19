using System;
using System.Numerics;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = int.Parse(Console.ReadLine());

            var maxSnowBallSnow = 0;
            var maxSnowBallTime = 0;
            var maxSnowBallQuality = 0;
            BigInteger maxValue = 0;

            for (int i = 0; i < inputs; i++)
            {
                var snowBallSnow = int.Parse(Console.ReadLine());
                var snowBallTime = int.Parse(Console.ReadLine());
                var snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger snowBalls = snowBallSnow / snowBallTime;
                BigInteger finalProduct = BigInteger.Pow(snowBalls, snowBallQuality);

                if(finalProduct >= maxValue)
                {
                    maxValue = finalProduct;
                    maxSnowBallTime = snowBallTime;
                    maxSnowBallSnow = snowBallSnow;
                    maxSnowBallQuality = snowBallQuality;
                }

            }

            Console.WriteLine($"{maxSnowBallSnow} : {maxSnowBallTime} = {maxValue} ({maxSnowBallQuality})");
        }
    }
}
