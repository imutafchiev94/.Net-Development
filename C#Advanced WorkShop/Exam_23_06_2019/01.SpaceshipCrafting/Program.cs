using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int glass = 25;

            const int aluminium = 50;

            const int lithium = 75;

            const int carbonFiber = 100;

            var liquidsInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var liquids = new Queue<int>();

            for (int i = 0; i < liquidsInput.Length; i++)
            {
                liquids.Enqueue(liquidsInput[i]);
            }

            var phisicalInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var phisicals = new Stack<int>();

            for (int i = 0; i < phisicalInput.Length; i++)
            {
                phisicals.Push(phisicalInput[i]);
            }

            var isAdvancedMaterials = true;

            SortedDictionary<string, int> advancedMaterials = new SortedDictionary<string, int>();

            advancedMaterials.Add("Glass", 0);
            advancedMaterials.Add("Aluminium", 0);
            advancedMaterials.Add("Lithium", 0);
            advancedMaterials.Add("Carbon fiber", 0);

            while (phisicals.Count != 0 && liquids.Count != 0)
            {
                var phisicMaterial = phisicals.Pop();

                var liquidMaterial = liquids.Dequeue();

                if(liquidMaterial + phisicMaterial == glass)
                {

                    advancedMaterials["Glass"]++;

                }
                else if (liquidMaterial + phisicMaterial == aluminium)
                {

                    advancedMaterials["Aluminium"]++;

                }
                else if (liquidMaterial + phisicMaterial == lithium)
                {
                    
                    advancedMaterials["Lithium"]++;
                    
                }
                else if (liquidMaterial + phisicMaterial == carbonFiber)
                {

                    advancedMaterials["Carbon fiber"]++;

                }

                else
                {
                    phisicMaterial += 3;
                    phisicals.Push(phisicMaterial);
                }
            }

            if (advancedMaterials["Glass"] == 0 || advancedMaterials["Aluminium"] == 0
                || advancedMaterials["Lithium"] == 0 || advancedMaterials["Carbon fiber"] == 0)
            {
                isAdvancedMaterials = false;
            }

            if(!isAdvancedMaterials)
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");

                if(liquids.Count == 0)
                {
                    Console.WriteLine($"Liquids left: none");
                }
                else
                {
                    Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
                }

                if(phisicals.Count == 0)
                {
                    Console.WriteLine($"Physical items left: none");
                }
                else
                {
                    Console.WriteLine($"Physical items left: {string.Join(", ", phisicals)}");
                }

                foreach (var advanced in advancedMaterials.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"{advanced.Key}: {advanced.Value}");
                }
            }
            else
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");

                if (liquids.Count == 0)
                {
                    Console.WriteLine($"Liquids left: none");
                }
                else
                {
                    Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
                }

                if (phisicals.Count == 0)
                {
                    Console.WriteLine($"Physical items left: none");
                }
                else
                {
                    Console.WriteLine($"Physical items left: {string.Join(", ", phisicals)}");
                }

                foreach (var advanced in advancedMaterials.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"{advanced.Key}: {advanced.Value}");
                }
            }
        }
    }
}
