using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var malesInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var males = new Stack<int>();

            for (int i = 0; i < malesInput.Length; i++)
            {
                if(malesInput[i] > 0)
                {
                    males.Push(malesInput[i]);
                }
            }

            var matched = 0;

            var femaleInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var females = new Queue<int>();

            for (int i = 0; i < femaleInput.Length; i++)
            {
                if(femaleInput[i] > 0)
                {
                    females.Enqueue(femaleInput[i]);
                }
            }

            bool isFemaleForRemove = false;

            bool isMaleForRemove = false;

            while (females.Count != 0 && males.Count != 0)
            {
                var female = -1;

                if(!isMaleForRemove)
                {
                    female = females.Dequeue();
                    isFemaleForRemove = false;
                }

                var male = -1;

                if (!isFemaleForRemove)
                {
                    male = males.Pop();
                    isMaleForRemove = false;
                }

                if(female % 25 == 0)
                {
                    isFemaleForRemove = true;
                }
                if(male % 25 == 0)
                {
                    isMaleForRemove = true;
                }

                if(male > 0 && female > 0)
                {
                    if(male == female)
                    {
                        matched++;
                    }
                    else
                    {
                        if(male - 2 > 0)
                        {
                            male -= 2;
                            males.Push(male);
                        }
                    }
                }
            }

            Console.WriteLine($"Matches: {matched}");

            if(males.Count == 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }
            if(females.Count == 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
        }
    }
}
