using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            

            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            while (n != 0)
            {
                var input = Console.ReadLine().Split().ToArray();

                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if(!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                    if(!continents[continent].ContainsKey(country))
                    {
                        continents[continent][country] = new List<string>();
                        continents[continent][country].Add(city);
                    }
                    else
                    {
                        continents[continent][country].Add(city);
                    }
                }
                else
                {
                    if (!continents[continent].ContainsKey(country))
                    {
                        continents[continent][country] = new List<string>();
                        continents[continent][country].Add(city);
                    }
                    else
                    {
                        continents[continent][country].Add(city);
                    }
                }
                n--;
            }


            foreach (var pair in continents)
            {
                Console.WriteLine($"{pair.Key}:");
                foreach (var country in pair.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
