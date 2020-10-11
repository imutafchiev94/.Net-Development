using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {

        private string type;

        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;

            this.Weight = weight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }

            private set
            {
                if(value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce" && value != "meat" 
                    && value != "veggies" && value != "cheese" && value != "sauce")
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{this.type} weight should be in the range[1..50].");
                }
                this.weight = value;
            }
        }


        public double CalculateCalories()
        {
            double calories = 0;
            
            if(this.type == "Meat".ToLower())
                    {
                        calories = 2 * (this.weight * 1.2);
                    }
            else if (this.type == "Veggies".ToLower())
                    {
                        calories = 2 * (this.weight * 0.8);
                    }
            else if (this.type == "Cheese".ToLower())
                    {
                        calories = 2 * (this.weight * 1.1);
                    }
            else if (this.type == "Sauce".ToLower())
                    {
                        calories = 2 * (this.weight * 0.9);
                    }
            else if (this.type == "Meat")
            {
                calories = 2 * (this.weight * 1.2);
            }
            else if (this.type == "Veggies")
            {
                calories = 2 * (this.weight * 0.8);
            }
            else if (this.type == "Cheese")
            {
                calories = 2 * (this.weight * 1.1);
            }
            else if (this.type == "Sauce")
            {
                calories = 2 * (this.weight * 0.9);
            }

            return calories;
        }

    }
}
