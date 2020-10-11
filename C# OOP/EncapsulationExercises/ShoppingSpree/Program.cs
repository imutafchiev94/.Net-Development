using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var allPersons = Console.ReadLine().Split(";").ToArray();

            var allProducts = Console.ReadLine().Split(";").ToArray();

            var persons = new List<Person>();

            var products = new List<Product>();

            try
            {
                for (int i = 0; i < allPersons.Length; i++)
                {
                    if (allPersons[i] != "")
                    {
                        var person = allPersons[i].Split("=").ToArray();

                        Person p = new Person(person[0], double.Parse(person[1]));
                        persons.Add(p);
                    }

                }

                for (int i = 0; i < allProducts.Length; i++)
                {
                    if (allProducts[i] != "")
                    {
                        var product = allProducts[i].Split("=").ToArray();

                        Product p = new Product(product[0], double.Parse(product[1]));

                        products.Add(p);
                    }
                }


                var command = Console.ReadLine().Split(" ").ToArray();

                while (command[0] != "END")
                {
                    var person = persons.FirstOrDefault(p => p.Name == command[0]);
                    var product = products.FirstOrDefault(p => p.Name == command[1]);

                    person.Buy(product);

                    command = Console.ReadLine().Split(" ").ToArray();
                }

                foreach (var person in persons)
                {
                    if (person.BagOfProducts.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
                    }
                }

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
