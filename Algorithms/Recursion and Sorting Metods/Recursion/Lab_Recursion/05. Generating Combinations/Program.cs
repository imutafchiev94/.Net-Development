﻿using System;
using System.Linq;

namespace _05._Generating_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().ToArray();

            int k = int.Parse(Console.ReadLine());

            string[] nums2 = new string[k];

            GetCombination(nums, nums2, 0, -1);
        }

        public static void GetCombination(string[] arr, string[] result, int index, int border)
        {

            if(index >= result.Length)
            {
                Console.WriteLine(String.Join(" ", result));
            }

            else
            {
                for (int i = border + 1; i < arr.Length; i++)
                {
                    result[index] = arr[i];

                    GetCombination(arr, result, index + 1, i);
                }
            }

        }
    }
}
