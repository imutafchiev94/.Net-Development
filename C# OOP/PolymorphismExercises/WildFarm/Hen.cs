using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void WantFood()
        {
            Console.WriteLine("Cluck");
        }


        public override string ToString()
        {
            return $"Hen [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }

        public override void Eat(Food food)
        {
            var foodType = food.GetType();

            this.Weight += food.Quantity * 0.35;
            FoodEaten += food.Quantity;

        }
    }
}
