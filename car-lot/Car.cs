using System;

namespace car_lot
{
    public class Car : Vehicle
    {
        public override string LicenseNum {get; set;}
        public override string Make {get;set;}
        public override string Model {get; set;}
        public override double Price {get;set;}
        public string Type {get;set;}
        public int NumberOfDoors {get;set;} 

        public Car(string licenseNum, string make, string model, double price, string type, int numberOfDoors)
        {
            this.LicenseNum = licenseNum;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Type = type;
            this.NumberOfDoors = numberOfDoors;
        }
        public override void PrintDescription()
        {
            Console.WriteLine("Car Description:");
            Console.WriteLine("LicenseNum: " + LicenseNum);
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("NumberOfDoors: " + NumberOfDoors);
        }
    }
}
