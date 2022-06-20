using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagons = int.Parse(Console.ReadLine());

            var sum = 0;
            var passingers = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                var passingersPerWagon = int.Parse(Console.ReadLine());

                passingers[i] = passingersPerWagon;
                sum += passingersPerWagon;
            }

            foreach (var item in passingers)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n{sum}");
        }
    }
}
