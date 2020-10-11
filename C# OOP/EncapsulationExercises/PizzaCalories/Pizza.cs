using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {

        private string name;

        private List<Topping> toppings;

        

        public Pizza(string name, Dough dough)
        {
            this.Name = name;

            this.Dough = dough;

            this.toppings = new List<Topping>();

        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough { get; set; }

        public IReadOnlyCollection<Topping> Toppings
        {
            get
            {
                return this.toppings.AsReadOnly();
            }
        }

        public double TotalCalories
        {
            get
            {
                return CalculateTotalCalories();
            }
        }

        public void AddTopping(Topping topping)
        {
            if(this.toppings.Count < 10)
            {
                this.toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }

        private double CalculateTotalCalories()
        {
            double totalCalories;

            var doughtCalories = this.Dough.CalculateCalories();

            double toppingCalories = 0;

            foreach(var topping in this.toppings)
            {
                toppingCalories += topping.CalculateCalories();
            }

            totalCalories = doughtCalories + toppingCalories;

            return totalCalories;
        }

        public override string ToString()
        {
            return $"{this.name} - {string.Format("{0:0.00}", this.TotalCalories)} Calories.";
        }
    }
}
