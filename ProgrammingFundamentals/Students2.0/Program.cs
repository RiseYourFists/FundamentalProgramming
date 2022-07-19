using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string location)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = location;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var Students = new List<Student>();

            while (input != "end")
            {
                var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var firstName = tokens[0];
                var lastName = tokens[1];
                var age = int.Parse(tokens[2]);
                var location = tokens[3];

                bool doesExist = Students.Any(x => x.FirstName == firstName && x.LastName == lastName);

                if(doesExist)
                {
                    var item = Students.FindIndex(x => x.FirstName == firstName && x.LastName == lastName);
                    Students[item].Age = age;
                    Students[item].HomeTown = location;
                    input = Console.ReadLine();
                    continue;
                }

                var newStudent = new Student(firstName, lastName, age, location);
                Students.Add(newStudent);

                input = Console.ReadLine();
            }

            string filter = Console.ReadLine();

            var result = Students.Where(x => x.HomeTown == filter).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }
}
