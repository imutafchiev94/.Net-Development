using System;
using System.Collections.Generic;
using System.Text;

namespace Vechiles
{
    public class Truck : Vechile
    {
        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity) 
            : base(fuelQuantity, litersPerKm, tankCapacity)
        {

            this.litersPerKm = litersPerKm + 1.6;

        }

        public override void Drive(double distance)
        {
            if (this.fuelQuantity >= this.litersPerKm * distance)
            {
                this.fuelQuantity -= this.litersPerKm * distance;

                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
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
                    this.fuelQuantity += liters * 0.95;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
            }
        }

        public override string ToString()
        {
            return $"Truck: {String.Format("{0:0.00}", this.fuelQuantity)}";
        }
    }
}
