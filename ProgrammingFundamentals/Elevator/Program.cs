using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var extraCourse = (people % capacity >= 1) ? 1 : 0;
            var courses = (people / capacity) + extraCourse;

            Console.WriteLine(courses);
        }
    }
}
