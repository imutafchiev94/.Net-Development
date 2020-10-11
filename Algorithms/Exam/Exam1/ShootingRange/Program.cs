using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                var sum = 0;
                var arr = new List<int>();
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    if(sum + (input[i] * input[j]) <= n)
                    {
                        sum += (input[i] * input[j]);
                        arr.Add(input[j]);
                    }
                }
                if(sum == n)
                {
                    Console.WriteLine(string.Join(" ", arr));
                }
            }

            
        }
    }
}
