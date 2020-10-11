using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            var dictionary = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if(!dictionary.Keys.Contains(input[i]))
                {
                    dictionary[input[i]] = 1;
                }
                else
                {
                    dictionary[input[i]]++;
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
