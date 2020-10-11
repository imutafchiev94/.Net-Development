using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> products = new Dictionary<string, Dictionary<string, double>>();

            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "Revision")
            {
                var shop = input[0];
                var name = input[1];
                var price = double.Parse(input[2]);

                if(!products.ContainsKey(shop))
                {
                    products[shop] = new Dictionary<string, double>();
                    products[shop][name] = price;
                }
                else if(products.ContainsKey(shop))
                {
                    products[shop][name] = price;
                }


                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var product in products.OrderBy(x => x.Key))
            {
                Console.WriteLine(product.Key + "->");

                foreach (var item in product.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }

            }
        }
    }
}
