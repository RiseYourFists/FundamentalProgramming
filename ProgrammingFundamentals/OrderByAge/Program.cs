using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderByAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Person>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                var tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var id = tokens[1];
                var age = int.Parse(tokens[2]);

                if (users.Any(x => x.ID == id))
                {
                    var position = users.FindIndex(x => x.ID == id);
                    users.RemoveAt(position);
                }

                var newPerson = new Person(name, id, age);
                users.Add(newPerson);
            }

            users = users.OrderBy(x => x.Age).ToList();
            var result = FormatUserList(users);
            Console.WriteLine(result);
        }

        private static string FormatUserList(List<Person> users)
        {
            var result = new StringBuilder();
            foreach (var item in users)
            {
                result.AppendLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }

            return result.ToString().TrimEnd();
        }
    }
}
