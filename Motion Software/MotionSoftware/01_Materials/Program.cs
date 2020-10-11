using System;

namespace _01_Materials
{
    class Program
    {
        static void Main(string[] args)
        {
            const int materialsMinnedByWorkers = 26;

            const int materialsDropedPerDay = 10;

            decimal materialsPerDay = decimal.Parse(Console.ReadLine());

            decimal days = 0;

            decimal materialsLeft = 0;

            if (materialsPerDay < 100)
            {
                days++;
                materialsLeft += materialsPerDay - materialsMinnedByWorkers;
            }
            else
            {
                while (materialsPerDay >= 100)
                {
                    days++;
                    materialsLeft += materialsPerDay - materialsMinnedByWorkers;
                    materialsPerDay -= materialsDropedPerDay;
                }
            }
                materialsLeft -= materialsMinnedByWorkers;

            Console.WriteLine(days);
            Console.WriteLine(materialsLeft);
        }
    }
}
