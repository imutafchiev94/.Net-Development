using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };

            var arr2 = new int[6];

            Console.WriteLine(arr.ToList().Count);

            Console.WriteLine(arr2.ToList().Count());
        }
    }
}
