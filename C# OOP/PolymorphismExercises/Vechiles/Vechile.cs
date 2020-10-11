using System;
using System.Collections.Generic;
using System.Text;

namespace Vechiles
{
    public abstract class Vechile
    {

        protected double fuelQuantity;

        protected double litersPerKm;

        protected double tankCapacity;

        public Vechile(double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            this.fuelQuantity = fuelQuantity;

            this.litersPerKm = litersPerKm;

            this.tankCapacity = tankCapacity;
        }


        public abstract void Drive(double distance);

        public abstract void Refuel(double liters);
    }
}
