using System;
using System.Collections.Generic;
using System.Text;

namespace Vechiles
{
    public class Car : Vechile
    {
        public Car(double fuelQuantity, double litersPerKm, double tankCapacity) 
            : base(fuelQuantity, litersPerKm, tankCapacity)
        {
            this.litersPerKm = litersPerKm + 0.9;
        }

        public override void Drive(double distance)
        {

            if(this.fuelQuantity >= this.litersPerKm * distance)
            {
                this.fuelQuantity -= this.litersPerKm * distance;

                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (this.tankCapacity >= this.fuelQuantity + liters)
                {
                    this.fuelQuantity += liters;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
            }
        }

        public override string ToString()
        {
            return $"Car: {String.Format("{0:0.00}", this.fuelQuantity)}";
        }
    }
}
