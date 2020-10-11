using System;
using System.Collections.Generic;
using System.Linq;

namespace MonkeyBusiness
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] arr = new int[count * 2];

            for (int i = 0; i < arr.Length; i += 2)
            {
                arr[i] = i + 1;
                arr[i + 1] = (i + 1) * -1;
            }

            zero_sum(1, count, "1", 1);
        }

        // Prints all triplets in arr[] with 0 sum 
        static void zero_sum(int cur, int n, string seq, int sum)
        {
            if (cur == n && sum == 0)
            {
                Console.WriteLine(seq);
            }
            else if(cur < n)
            {
                zero_sum(cur + 1, n, seq + " - " + (cur + 1).ToString(), sum - (cur + 1));
                zero_sum(cur + 1, n, seq + " + " + (cur + 1).ToString(), sum - (cur + 1));
            }

            

            Console.WriteLine($"Total Solutions:");
        }
    }
}
