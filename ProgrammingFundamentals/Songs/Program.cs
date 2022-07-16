using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Songs
    {
        public Songs(string name, string type, string time)
        {
            Name = name;
            Type = type;
            Time = time;
        }

        public string Name{ get; set; }
        public string Type { get; set; }
        public string Time{ get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var songList = new List<Songs>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('_',StringSplitOptions.RemoveEmptyEntries).ToList();
                string type = input[0];
                string name = input[1];
                string time = input[2];

                var newSong = new Songs(name, type, time);
                songList.Add(newSong);
            }

            var command = Console.ReadLine();

            if(command == "all")
            {
                foreach (var item in songList)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                var result = songList.FindAll(x => x.Type == command).ToList();
                foreach (var item in result)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
