using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            var separator = new string[] { " -> ", "," };

            while(n != 0)
            {
                var input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

                var color = input[0];

                for (int i = 1; i < input.Length; i++)
                {
                    var cloth = input[i];

                    if(!clothes.ContainsKey(color))
                    {
                        clothes[color] = new Dictionary<string, int>();
                        clothes[color][cloth] = 1;
                    }
                    else
                    {
                        if (!clothes[color].ContainsKey(cloth))
                        {
                            clothes[color][cloth] = 1;
                        }
                        else
                        {
                            clothes[color][cloth]++;
                        }
                    }
                }

                n--;
            }

            var searchedItem = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            foreach (var cloth in clothes)
            {
                Console.WriteLine($"{cloth.Key} clothes:");
                foreach (var item in cloth.Value)
                {
                    if (searchedItem[0] == cloth.Key && searchedItem[1] == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
