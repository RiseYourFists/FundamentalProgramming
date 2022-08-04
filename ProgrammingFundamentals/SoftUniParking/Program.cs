using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class ParkingTicket
    {
        public ParkingTicket(string user, string licensePlate, bool hasParked)
        {
            User = user;
            LicensePlate = licensePlate;
            HasParked = hasParked;
        }

        public string User { get; set; }
        public string LicensePlate { get; set; }
        public bool HasParked { get; set; }
    }

    class Register
    {
        public Register()
        {
            RegList = new Dictionary<string, ParkingTicket>();
        }
        public Dictionary<string, ParkingTicket> RegList { get; set; }

        public void ValidateAndAdd(string user, string licensePlate)
        {
            if (!this.RegList.ContainsKey(user))
            {
                this.RegList.Add(user, new ParkingTicket(user, licensePlate, true));
                Console.WriteLine($"{user} registered {licensePlate} successfully");
                return;
            }

            Console.WriteLine($"ERROR: already registered with plate number {RegList[user].LicensePlate}");
        }

        public void RegisterDeparture(string user)
        {
            if (this.RegList.ContainsKey(user))
            {
                this.RegList[user].HasParked = false;
                Console.WriteLine($"{user} unregistered successfully");
                return;
            }

            Console.WriteLine($"ERROR: user {user} not found");
        }

        public void PrintParkedUsers()
        {
            var userList = this.RegList.Where(x => x.Value.HasParked == true);
            foreach (var item in userList)
            {
                Console.WriteLine($"{item.Key} => {item.Value.LicensePlate}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var registration = new Register();

            var inputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputs; i++)
            {
                var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var action = tokens[0];
                var user = tokens[1];

                if (action == "register")
                {
                    var licensePlate = tokens[2];

                    registration.ValidateAndAdd(user, licensePlate);
                }
                else
                {
                    registration.RegisterDeparture(user);
                }

            }

            registration.PrintParkedUsers();
        }
    }
}
