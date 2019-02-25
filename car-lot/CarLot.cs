using System;
using System.Collections.Generic;

namespace car_lot
{
    public class CarLot
    {
        public string Name { get; set; }    
        public List<Vehicle> Vehicles = new List<Vehicle>();    

        public CarLot(string name)
        {
            this.Name = name;
        }

        public void AddToLot (Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void PrintInventory()
        {
            foreach (var item in Vehicles)
            {
                item.PrintDescription();
            }

            System.Console.WriteLine($"There are {Vehicles.Count} vehicles in {Name}");
        }
    }
}
