using System;
using System.Collections.Generic;
using System.Text;

namespace Vechiles
{
    public class Bus : Vechile
    {
        public Bus(double fuelQuantity, double litersPerKm, double tankCapacity) 
            : base(fuelQuantity, litersPerKm, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (this.fuelQuantity >= (this.litersPerKm + 1.4) * distance)
            {
                this.fuelQuantity -= (this.litersPerKm + 1.4) * distance;

                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }

        public void DriveEmpty(double distance)
        {
            if (this.fuelQuantity >= this.litersPerKm * distance)
            {
                this.fuelQuantity -= this.litersPerKm * distance;

                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
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
            return $"Bus: {String.Format("{0:0.00}", this.fuelQuantity)}";
        }
    }
}
