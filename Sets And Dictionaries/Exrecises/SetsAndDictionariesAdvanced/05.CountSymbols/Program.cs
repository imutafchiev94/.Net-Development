using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();

            var str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                var character = str[i];

                if(!characters.ContainsKey(character))
                {
                    characters[character] = 1;
                }
                else
                {
                    characters[character]++;
                }
            }


            foreach (var chars in characters.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{chars.Key}: {chars.Value} time/s");
            }
        }
    }
}
