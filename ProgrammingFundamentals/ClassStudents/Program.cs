using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassStudents
{
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public Student()
        {
            this.StudentList = new List<Student>();
        }

        public List<Student> StudentList{ get; set; }

        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public void SortByDecending()
        {
            var result = this.StudentList.OrderByDescending(x => x.Grade).ToList();
           this.StudentList = result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var studentsCount = int.Parse(Console.ReadLine());
            var newClass = new Student();

            for (int i = 0; i < studentsCount; i++)
            {
                var temp = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
                var newInput = string.Join("", temp);
                var input = newInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var firstName = input[0];
                var lastName = input[1];
                var grade = double.Parse(input[2]);

                var newStudent = new Student(firstName, lastName, grade);
                newClass.StudentList.Add(newStudent);
            }

            newClass.SortByDecending();

            foreach (var item in newClass.StudentList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }
        }
    }
}
