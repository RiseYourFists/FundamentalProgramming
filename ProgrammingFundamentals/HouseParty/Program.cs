using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandCount = int.Parse(Console.ReadLine());
            var memebers = new List<string>();

            for (int i = 0; i < commandCount; i++)
            {
                var guestAction = Console.ReadLine();
                var details = guestAction.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = details[0];
                var action = details[2];

                if(action == "going!")
                {
                    if (!IsInList(memebers, name))
                    {
                        memebers.Add(name);
                        continue;
                    }

                    Console.WriteLine($"{name} is already in the list!");
                }
                else
                {
                    if(IsInList(memebers, name))
                    {
                        memebers.Remove(name);
                        continue;
                    }

                    Console.WriteLine($"{name} is not in the list!");
                }

            }

            foreach (var member in memebers)
            {
                Console.WriteLine(member);
            }
        }

        static bool IsInList(List<string> collection, string target)
        {
            if(collection.Contains(target))
            {
                return true;
            }

            return false;
        }
    }
}
