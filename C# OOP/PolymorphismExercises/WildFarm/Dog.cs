using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void WantFood()
        {
            Console.WriteLine("Woof!");
        }

        public override string ToString()
        {
            return $"Dog [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void Eat(Food food)
        {
            var foodType = food.GetType();

            if (foodType.Equals(typeof(Meat)))
            {
                this.Weight += food.Quantity * 0.40;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Dog does not eat {foodType.Name}!");
            }
        }
    }
}
