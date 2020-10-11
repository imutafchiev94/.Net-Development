using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolTeams
{
    class Program
    {
        static void Main(string[] args)
        {

            var girlsInput = Console.ReadLine().Split(", ").ToArray();
            var boysInput = Console.ReadLine().Split(", ").ToArray();

            

        }


        private static void permute(string[] str, List<string> places,
                                int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                var result = new List<string>();
                for (int i = l; i <= r; i++)
                {
                    foreach (var place in places)
                    {
                        if(place.Contains(i.ToString()))
                        {
                            var p = place.Split(" - ").ToArray();
                            result.Add(p[0]);
                        }
                    }
                    if(!result.Contains(str[i]))
                    {
                        str = swap(str, l, i);
                        permute(str, places,l + 1, r);
                        str = swap(str, l, i);
                    }
                    
                }
            }
        }

        public static string[] swap(string[] a,
                              int i, int j)
        {
            string temp;
            string[] str = a;
            temp = str[i];
            str[i] = str[j];
            str[j] = temp;
            string[] s = str;
            return s;
        }
    }
}
