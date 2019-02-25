using System;

namespace car_lot
{
    public class Truck : Vehicle
    {
        public override string LicenseNum {get; set;}
        public override string Make {get;set;}
        public override string Model {get; set;}
        public override double Price {get;set;}
        public int BedSizeInFeet {get;set;}

        public Truck(string licenseNum, string make, string model, double price, int bedSizeInFeet)
        {
            this.LicenseNum = licenseNum;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.BedSizeInFeet = bedSizeInFeet;
        }
        public override void PrintDescription()
        {
            Console.WriteLine("Car Description:");
            Console.WriteLine("LicenseNum: " + LicenseNum);
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Bed Size (in feet): " + BedSizeInFeet);
            Console.WriteLine(myint);
        }

    }
}
