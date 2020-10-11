using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void WantFood()
        {
            Console.WriteLine("Squeak");
        }

        public override string ToString()
        {
            return $"Mouse [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void Eat(Food food)
        {
            var foodType = food.GetType();

            if (foodType.Equals(typeof(Vegetable)) || foodType.Equals(typeof(Fruit)))
            {
                this.Weight += food.Quantity * 0.10;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Mouse does not eat {foodType.Name}!");
            }
        }
    }
}
