    using System;
    using System.Linq;

    namespace _01._Permutations_without_Repetition
    {
        class Program
        {

            static string[] elements;
            static void Main(string[] args)
            {
                elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Permutation(0);
            }

            static void Permutation(int index)
            {
                if(index >= elements.Length)
                {
                    Console.WriteLine(String.Join(" ", elements));
                }

                else
                {
                    Permutation(index + 1);
                    for (int i = index + 1; i < elements.Length; i++)
                    {
                        Swap(index, i);
                        Permutation(index + 1);
                        Swap(index, i);
                    }
                }
            }

            static void Swap(int first, int second)
            {
                string temp = elements[first];
                elements[first] = elements[second];
                elements[second] = temp;
            }
        }
    }
