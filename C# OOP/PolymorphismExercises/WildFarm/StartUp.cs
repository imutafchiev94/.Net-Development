using System;
using System.Collections.Generic;
using System.Linq;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Queue<Animal> animals = new Queue<Animal>();
            List<Animal> listAnimals = new List<Animal>();

            var input = Console.ReadLine().Split(" ").ToArray();

            while (input[0] != "End")
            {
                if(input.Length > 2)
                {
                    switch(input[0])
                    {
                        case "Hen":
                            {
                                Hen hen = new Hen(input[1], double.Parse(input[2]), double.Parse(input[3]));
                                hen.WantFood();

                                animals.Enqueue(hen);
                                break;
                            }
                        case "Owl":
                            {
                                Owl owl = new Owl(input[1], double.Parse(input[2]), double.Parse(input[3]));
                                owl.WantFood();

                                animals.Enqueue(owl);
                                break;
                            }
                        case "Mouse":
                            {
                                Mouse mouse = new Mouse(input[1], double.Parse(input[2]), input[3]);
                                mouse.WantFood();

                                animals.Enqueue(mouse);
                                break;
                            }
                        case "Cat":
                            {
                                Cat cat = new Cat(input[1], double.Parse(input[2]), input[3], input[4]);
                                cat.WantFood();

                                animals.Enqueue(cat);
                                break;
                            }
                        case "Dog":
                            {
                                Dog dog = new Dog(input[1], double.Parse(input[2]), input[3]);
                                dog.WantFood();

                                animals.Enqueue(dog);
                                break;
                            }
                        case "Tiger":
                            {
                                Tiger tiger = new Tiger(input[1], double.Parse(input[2]), input[3], input[4]);
                                tiger.WantFood();

                                animals.Enqueue(tiger);
                                break;
                            }
                    }
                }
                else
                {
                    switch(input[0])
                    {
                        case "Vegetable":
                            {
                                Vegetable vegetable = new Vegetable(int.Parse(input[1]));

                                var animal = animals.Dequeue();
                                listAnimals.Add(animal);
                                animal.Eat(vegetable);
                                break;
                            }
                        case "Fruit":
                            {
                                Fruit fruit = new Fruit(int.Parse(input[1]));

                                var animal = animals.Dequeue();
                                listAnimals.Add(animal);
                                animal.Eat(fruit);
                                break;
                            }
                        case "Meat":
                            {
                                Meat meat = new Meat(int.Parse(input[1]));

                                var animal = animals.Dequeue();
                                listAnimals.Add(animal);
                                animal.Eat(meat);
                                break;
                            }
                        case "Seeds":
                            {
                                Seeds seeds = new Seeds(int.Parse(input[1]));

                                var animal = animals.Dequeue();
                                listAnimals.Add(animal);
                                animal.Eat(seeds);
                                break;
                            }
                    }
                }

                input = Console.ReadLine().Split(" ").ToArray();
            }

            foreach (var animal in listAnimals)
            {
                Console.WriteLine(animal.ToString());   
            }
        }
    }
}
