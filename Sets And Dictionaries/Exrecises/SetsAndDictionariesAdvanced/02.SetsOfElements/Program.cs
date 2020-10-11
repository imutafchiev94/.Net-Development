using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var set1 = new HashSet<int>();

            var set2 = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                var num = int.Parse(Console.ReadLine());

                set1.Add(num);
            }

            for (int i = 0; i < input[1]; i++)
            {
                var num = int.Parse(Console.ReadLine());

                set2.Add(num);
            }

            var finalSet = new HashSet<int>();

            foreach (var number in set1)
            {
                foreach (var num in set2)
                {
                    if(number == num)
                    {
                        finalSet.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", finalSet));
        }
    }
}
