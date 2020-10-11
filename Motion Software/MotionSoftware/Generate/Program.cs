using System;

namespace Generate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int k = int.Parse(Console.ReadLine());

            char symbol3 = 'a';

            char symbol4 = 'a';


            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                        for (int m = 0; m < k; m++)
                        {
                            for (int o = 2; o <= n; o++)
                            {
                                if(o > i && o > j )
                                {
                                    Console.Write($"{i}{j}{Char.ConvertFromUtf32(symbol3 + l)}{Char.ConvertFromUtf32(symbol4 + m)}{o} ");
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
