using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Student
    {
        public Student(string name)
        {
            StudentName = name;
            Grades = new List<double>();
        }
        public string StudentName { get; set; }
        public List<double> Grades { get; set; }
        public double AvarageGrade { get; set; }

        public void AvgGrade()
        {
            var gradesSum = this.Grades.Sum();
            this.AvarageGrade = gradesSum / this.Grades.Count;
        }

    }

    class StudentsList
    {
        public StudentsList()
        {
            Students = new Dictionary<string, Student>();
        }
        public Dictionary<string, Student> Students { get; set; }

        public void ValidateAndAdd(string name, double grade)
        {
            if (!this.Students.ContainsKey(name))
            {
                var newStudent = new Student(name);
                this.Students.Add(name, newStudent);
                this.Students[name].Grades.Add(grade);
                return;
            }

            this.Students[name].Grades.Add(grade);
        }

        public void FinalizeGrades()
        {
            foreach (var item in this.Students)
            {
                item.Value.AvgGrade();
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var gradesInput = int.Parse(Console.ReadLine());
            var studentList = new StudentsList();
            for (int i = 0; i < gradesInput; i++)
            {
                var name = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());

                studentList.ValidateAndAdd(name, grade);

            }

            studentList.FinalizeGrades();

            var goodGraders = studentList.Students.Where(x => x.Value.AvarageGrade >= 4.5);
            foreach (var item in goodGraders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.AvarageGrade:f2}");
            }

        }
    }
}
