using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var amountOfSpace = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int maxSpace = int.Parse(Console.ReadLine());

            Dictionary<int, int> valuesAndSpace = new Dictionary<int, int>();

            for (int i = 0; i < values.Length; i++)
            {
                valuesAndSpace[values[i]] = amountOfSpace[i];
            }

            var sortedDictionary = valuesAndSpace.OrderByDescending(v => v.Key);

            var maxValue = 0;

            foreach (var item in sortedDictionary)
            {
                if(item.Value <= maxSpace)
                {
                    maxSpace -= item.Value;
                    maxValue += item.Key;
                }
            }

            Console.WriteLine($"Maximum value: {maxValue}");
        }
    }
}
