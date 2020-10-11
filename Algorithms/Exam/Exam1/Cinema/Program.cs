using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(", ").ToArray();

            var input = Console.ReadLine();

            var places = new List<string>();

            while(input != "generate")
            {
                places.Add(input);

                input = Console.ReadLine();
            }

            var list = new List<string>();
            int n = names.Length;
            permute(names, places, list, 0, n - 1);
        }

        private static void permute(string[] str, List<string> places,List<string> result,
                                int l, int r)
        {

            if (l == r)
            {
                Console.WriteLine(string.Join(", ", result));
                result = new List<string>();
            }

            else
            {

                for (int i = l; i <= r; i++)
                {
                    foreach (var place in places)
                    {
                        if (place.Contains((i + 1).ToString()))
                        {
                            var p = place.Split(" - ").ToArray();
                            result.Add(p[0]);
                        }
                    }
                    if (!result.Contains(str[i]))
                    {
                        if(result.Count == i + 1)
                        {
                            str = swap(str, l, i);
                            permute(str, places, result, l + 1, r);
                            str = swap(str, l, i);
                        }
                        
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
