using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }

                var tokens = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                var course = tokens[0];
                var student = tokens[1];

                if(!studentList.ContainsKey(course))
                {
                    studentList.Add(course, new List<string> { student });
                    continue;
                }

                studentList[course].Add(student);
            }

            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", item.Value)}");
            }
        }
    }
}
