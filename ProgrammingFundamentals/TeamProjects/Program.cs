using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamProjects
{
    class Team
    {
        public Team(string creator, string teamName)
        {
            TeamCreator = creator;
            TeamName = teamName;

            this.Users = new List<string>();
            Users.Add(creator);

            Console.WriteLine($"Team {this.TeamName} has been created by {this.TeamCreator}!");
        }

        public List<string> Users { get; set; } 
        public string TeamName { get; set; }
        public string TeamCreator { get; set; }
    }

    class TeamList
    {
        public TeamList()
        {
            this.Crews = new List<Team>();
        }

        public List<Team> Crews { get; set; }

        public void AddUser(string teamName, string user)
        {
            int teamIndex = this.Crews.FindIndex(x => x.TeamName == teamName);
            Crews[teamIndex].Users.Add(user);
        }

        public bool AlreadyInTeam (string user)
        {
            foreach (var item in Crews)
            {
                if(item.Users.Any(x => x == user))
                {
                    return true;
                }
            }
            return false;
        }

        public bool DoesTeamExist(string compare)
        {
            foreach (var item in Crews)
            {
                if(item.TeamName == compare)
                {
                    return true;
                }
            }
            return false;
        }

        public void SortUsers()
        {
            foreach (var item in Crews)
            {
                int creatorIndex = item.Users.FindIndex(x => x == item.TeamCreator);
                item.Users.RemoveAt(creatorIndex);

                if(item.Users.Count == 0)
                {
                    continue;
                }

                item.Users.Sort();
            }
        }

        public void SortCrews()
        {
            var result = Crews
                .OrderByDescending(x => x.Users.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            Crews = result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var teams = int.Parse(Console.ReadLine());

            var newCrew = new TeamList();

            for (int i = 0; i < teams; i++)
            {
                var input = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
                var creator = input[0];
                var teamName = input[1];

                bool teamExists = newCrew.Crews.Any(x => x.TeamName == teamName);

                if(teamExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                bool creatorExists = newCrew.Crews.Any(x => x.TeamCreator == creator);

                if(creatorExists)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                var newTeam = new Team(creator, teamName);
                
                newCrew.Crews.Add(newTeam);
            }

            var command = Console.ReadLine();

            while (command != "end of assignment")
            {
                var tokens = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                var user = tokens[0];
                var teamToJoin = tokens[1];

                if(!newCrew.DoesTeamExist(teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    command = Console.ReadLine();
                    continue;
                }

                if(newCrew.AlreadyInTeam(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                    command = Console.ReadLine();
                    continue;
                }

                newCrew.AddUser(teamToJoin, user);

                command = Console.ReadLine();
            }

            newCrew.SortCrews();
            newCrew.SortUsers();

            foreach (var item in newCrew.Crews)
            {
                if (item.Users.Count == 0)
                {
                    continue;
                }

                Console.WriteLine($"{item.TeamName}");
                Console.WriteLine($"- {item.TeamCreator}");
                PrintUsers(item);
            }

            Console.WriteLine("Teams to disband:");
            var toDisband = newCrew.Crews.Where(x => x.Users.Count == 0);
            toDisband = toDisband.OrderBy(x => x.TeamName).ToList();

            foreach (var item in toDisband)
            {
                Console.WriteLine(item.TeamName);
            }
        }

        public static void PrintUsers(Team item)
        {
            foreach (var user in item.Users)
            {
                Console.WriteLine($"-- {user}");
            }
        }
    }
}
