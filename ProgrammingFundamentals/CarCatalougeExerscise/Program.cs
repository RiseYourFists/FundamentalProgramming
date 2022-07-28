using System;
using System.Collections.Generic;
using System.Linq;

namespace CarCatalogueExerscise
{
    class Car
    {
        public Car(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
            Type = "Car";
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public Truck(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
            Type = "Truck";
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {
            var newCatalouge = new Catalogue();
            var input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var type = tokens[0];
                var model = tokens[1];
                var color = tokens[2];
                var horsePower = int.Parse(tokens[3]);

                if (type == "car")
                {
                    var newCar = new Car(model, color, horsePower);
                    newCatalouge.Cars.Add(newCar);
                }

                if (type == "truck")
                {
                    var newTruck = new Truck(model, color, horsePower);
                    newCatalouge.Trucks.Add(newTruck);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                var model = input;
                var car = LookForModel(newCatalouge.Cars, model);
                var truck = LookForModel(newCatalouge.Trucks, model);

                if (car != null)
                {
                    Console.WriteLine($"Type: {car.Type}\nModel: {car.Model}\nColor: {car.Color}\nHorsepower: {car.HorsePower}");
                }

                if (truck != null)
                {
                    Console.WriteLine($"Type: {truck.Type}\nModel: {truck.Model}\nColor: {truck.Color}\nHorsepower: {truck.HorsePower}");
                }

                input = Console.ReadLine();
            }

            var carsHP = CarsTotalHP(newCatalouge);
            var trucksHP = TrucksTotalHP(newCatalouge);

            Console.WriteLine($"Cars have average horsepower of: {carsHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksHP:f2}.");

        }

        public static double TrucksTotalHP(Catalogue newCatalouge)
        {
            double result = 0;

            foreach (var item in newCatalouge.Trucks)
            {
                result += item.HorsePower;
            }

            int count = newCatalouge.Trucks.Count;
            if (count > 0)
            {
                result /= count;
            }

            return result;
        }

        public static double CarsTotalHP(Catalogue newCatalouge)
        {
            double result = 0;

            foreach (var item in newCatalouge.Cars)
            {
                result += item.HorsePower;
            }

            int count = newCatalouge.Cars.Count;
            if (count > 0)
            {
                result /= count;
            }

            return result;
        }

        public static Car LookForModel(List<Car> collection, string key)
        {
            var result = collection.FirstOrDefault(x => x.Model == key);
            return result;
        }

        public static Truck LookForModel(List<Truck> collection, string key)
        {
            var result = collection.FirstOrDefault(x => x.Model == key);
            return result;
        }


    }
}
