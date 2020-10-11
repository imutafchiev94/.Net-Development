using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        protected string Name;

        protected double Weight;

        protected int FoodEaten;

        public Animal(string name, double weight)
        {
            this.Name = name;

            this.Weight = weight;

            this.FoodEaten = 0;
        }


        public abstract void WantFood();

        public abstract void Eat(Food food);

    }
}
