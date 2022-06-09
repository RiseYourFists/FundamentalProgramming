﻿using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");

                sum += i;
            }

            Console.WriteLine($"\nSum: {sum}");
        }
    }
}
