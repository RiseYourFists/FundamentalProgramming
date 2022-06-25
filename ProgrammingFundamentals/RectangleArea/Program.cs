using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var result = RectangleArea(width, height);

            Console.WriteLine(result);
        }

        static double RectangleArea(double width, double height)
        {
            var result = width * height;
            return result;
        }
    }
}
