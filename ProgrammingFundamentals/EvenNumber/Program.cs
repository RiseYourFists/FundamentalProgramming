﻿using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            while (Math.Abs(number) % 2 == 1)
            {
                Console.WriteLine("Please write an even number.");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}
