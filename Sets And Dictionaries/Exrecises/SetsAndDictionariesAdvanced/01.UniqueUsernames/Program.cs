using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> userNames = new HashSet<string>();

            while(n != 0)
            {
                var userName = Console.ReadLine();

                userNames.Add(userName);

                n--;
            }

            foreach (var userName in userNames)
            {
                Console.WriteLine(userName);
            }
        }
    }
}
