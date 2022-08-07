using System;
using System.Collections.Generic;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyList = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine();
                if(input == "End")
                {
                    break;
                }

                var tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                var companyName = tokens[0];
                var userId = tokens[1];

                if(!companyList.ContainsKey(companyName))
                {
                    companyList.Add(companyName, new List<string> { userId });
                    continue;
                }

                bool doesExist = DoesUserExist(companyList, userId, companyName);

                if(!doesExist)
                {
                    companyList[companyName].Add(userId);
                }
                
            }

            foreach (var item in companyList)
            {
                Console.WriteLine(item.Key);

                foreach (var user in item.Value)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }

        public static bool DoesUserExist(Dictionary<string, List<string>> collection, string compare, string accessIndex)
        {
            if(collection[accessIndex].Contains(compare))
            {
                return true;
            }
            return false;
        }
    }
}
