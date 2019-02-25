using System;

namespace car_lot
{
    public abstract class Vehicle
    {
        public abstract string LicenseNum {get; set;}
        public abstract string Make { get; set; }
        public abstract string Model {get; set;}
        public abstract double Price {get;set;}
        public static int myint=3; 

        public abstract void PrintDescription();
        
    }
}
