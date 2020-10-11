using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight,string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void WantFood()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return $"Cat [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void Eat(Food food)
        {
            var foodType = food.GetType();

            if (foodType.Equals(typeof(Meat)) || foodType.Equals(typeof(Vegetable)))
            {
                this.Weight += food.Quantity * 0.30;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Cat does not eat {foodType.Name}!");
            }
        }
    }
}
