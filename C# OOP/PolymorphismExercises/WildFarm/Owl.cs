using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void WantFood()
        {
            Console.WriteLine("Hoot Hoot");
        }


        public override string ToString()
        {
            return $"Owl [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }

        public override void Eat(Food food)
        {
            var foodType = food.GetType();

            if(foodType.Equals(typeof(Meat)))
            {
                this.Weight += food.Quantity * 0.25;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Owl does not eat {foodType.Name}!");
            }
        }
    }
}
