using System;
using System.Numerics;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            BigInteger minutes = hours * 60;

            Console.WriteLine(minutes);
        }
    }
}
