using System;

namespace car_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle truck = new Truck("dkny", "mazda", "protege", 2500.99, 8);
            CarLot carLot = new CarLot("sam's lot");

            carLot.AddToLot(truck);
            carLot.PrintInventory();
        }
    }
}
