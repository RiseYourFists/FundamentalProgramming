using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalouge
{
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class VehicleCatalouge
    {
        public VehicleCatalouge()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars{ get; set; }
        public List<Truck> Trucks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var newCatalouge = new VehicleCatalouge();

            var input = Console.ReadLine();
            while (input != "end")
            {
                var tokens = input.Split('/', StringSplitOptions.RemoveEmptyEntries);

                var brand = tokens[1];
                var model = tokens[2];
                var lastParam = int.Parse(tokens[3]);

                if (tokens[0] == "Car")
                {
                    var newCar = new Car(brand, model, lastParam);
                    newCatalouge.Cars.Add(newCar);
                }

                if(tokens[0] == "Truck")
                {
                    var newTruck = new Truck(brand, model, lastParam);
                    newCatalouge.Trucks.Add(newTruck);
                }
                input = Console.ReadLine();
            }

            var carCatalouge = newCatalouge.Cars.OrderBy(x => x.Brand).ToList();
            var truckCatalouge = newCatalouge.Trucks.OrderBy(x => x.Brand).ToList();


            Console.WriteLine("Cars:");
            foreach (var item in carCatalouge)
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var item in truckCatalouge)
            {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
            }
        }
    }
}
