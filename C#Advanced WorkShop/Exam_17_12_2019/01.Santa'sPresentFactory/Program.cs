using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Santa_sPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var materialsInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var materials = new Stack<int>();

            var magicsInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var magics = new Queue<int>();

            const int doll = 150;

            const int woodenTrain = 250;

            const int teddyBear = 300;

            const int bicycle = 400;   

            Dictionary<string, int> products = new Dictionary<string, int>();

            for (int i = 0; i < materialsInput.Length; i++)
            {
                if(materialsInput[i] != 0)
                {
                    materials.Push(materialsInput[i]);
                }                
            }

            for (int i = 0; i < magicsInput.Length; i++)
            {
                if(magicsInput[i] != 0)
                {
                    magics.Enqueue(magicsInput[i]);
                }  
            }

            while(materials.Count > 0 && magics.Count > 0)
            {
                var magic = magics.Dequeue();


                var material = materials.Pop();



                if(material < 0 || magic < 0)
                {
                    if(material + magic != 0)
                    {
                        materials.Push(material + magic);
                    }
                }
                else if (material != 0 && magic != 0)
                {
                    var result = material * magic;

                    if (result == doll)
                    {
                        if (!products.ContainsKey("Doll"))
                        {
                            products["Doll"] = 1;
                        }
                        else
                        {
                            products["Doll"]++;
                        }
                    }
                    else if (result == woodenTrain)
                    {
                        if (!products.ContainsKey("Wooden train"))
                        {
                            products["Wooden train"] = 1;
                        }
                        else
                        {
                            products["Wooden train"]++;
                        }
                    }
                    else if (result == teddyBear)
                    {
                        if (!products.ContainsKey("Teddy bear"))
                        {
                            products["Teddy bear"] = 1;
                        }
                        else
                        {
                            products["Teddy bear"]++;
                        }
                    }
                    else if (result == bicycle)
                    {
                        if (!products.ContainsKey("Bicycle"))
                        {
                            products["Bicycle"] = 1;
                        }
                        else
                        {
                            products["Bicycle"]++;
                        }
                    }
                    else
                    {
                        material += 15;
                        materials.Push(material);
                    }
                }
            }

            if(products.ContainsKey("Doll") && products.ContainsKey("Wooden train") 
                || products.ContainsKey("Teddy bear") && products.ContainsKey("Bicycle"))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
                
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if (materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            if (magics.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magics)}");
            }

            foreach (var product in products.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
        }
    }
}
