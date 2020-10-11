using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelingPoliceman
{
    class Program
    {
        static void Main(string[] args)
        {
            int fuel = int.Parse(Console.ReadLine());

            var carDamage = 0;

            var input = Console.ReadLine();

            var streets = new List<string>();

            while(input != "End")
            {
                streets.Add(input);

                input = Console.ReadLine();
            }

            var values = new List<int>();

            foreach (var street in streets)
            {

                var items = street.Split(", ").ToArray();

                var damage = int.Parse(items[1]);

                var pokemons = int.Parse(items[2]);

                int value = (10 * pokemons) - damage;

                values.Add(value);
            }

            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            var count = values.Count();

            for (int i = 0; i < count; i++)
            {
                var max = values.Max();
                var index = values.IndexOf(max);
                if(max > 0)
                keyValues[index] = max;

                values[i] = int.MinValue;
            }

            List<string> streetNames = new List<string>();
            var pokemon = 0;


            foreach (var item in keyValues)
            {
                var str = streets[item.Key].Split(", ").ToArray();

                var length = int.Parse(str[3]);

                if(fuel >= length)
                {
                    streetNames.Add(str[0]);
                    fuel -= length;
                    pokemon += int.Parse(str[2]);
                    carDamage += int.Parse(str[1]);
                }
            }


            Console.WriteLine(string.Join(" -> ", streetNames));
            Console.WriteLine($"Total pokemons caught -> {pokemon}");
            Console.WriteLine($"Total car damage -> {carDamage}");
            Console.WriteLine($"Fuel Left -> {fuel}");
        }
    }
}

