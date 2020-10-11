using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void WantFood()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override string ToString()
        {
            return $"Tiger [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void Eat(Food food)
        {
            var foodType = food.GetType();

            if (foodType.Equals(typeof(Meat)))
            {
                this.Weight += food.Quantity * 1.00;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Tiger does not eat {foodType.Name}!");
            }
        }
    }
}
