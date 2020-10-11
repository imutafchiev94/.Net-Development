using System;
using System.Collections.Generic;

namespace _05.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            while (n != 0)
            {
                string name = Console.ReadLine();

                names.Add(name);

                n--;
            }

            foreach (var name in names)
            {
                
                Console.WriteLine(name);
            }
        }
    }
}
