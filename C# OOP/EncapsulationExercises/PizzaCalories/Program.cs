using System;
using System.Linq;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var pizzaInput = Console.ReadLine().Split(" ").ToArray();

                var doughtInput = Console.ReadLine().Split(" ").ToArray();

                Dough dought = new Dough(doughtInput[1].ToLower(), doughtInput[2].ToLower(), double.Parse(doughtInput[3]));

                Pizza pizza = new Pizza(pizzaInput[1], dought);

                var toppingInput = Console.ReadLine().Split(" ").ToArray();
                
                while(toppingInput[0] != "END")
                { 
                    Topping topping = new Topping(toppingInput[1], double.Parse(toppingInput[2]));

                    pizza.AddTopping(topping);

                    toppingInput = Console.ReadLine().Split(" ").ToArray();
                }

                Console.WriteLine(pizza);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
