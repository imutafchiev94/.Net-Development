    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace _02._Permutations_with_Repetition
    {
        class Program
        {
            static char[] elements;
            static void Main(string[] args)
            {
                elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                Array.Sort(elements);
                PermuteRep(elements, 0, elements.Length - 1);
            }

            static void PermuteRep(char[] arr, int start, int end)
            {
                Print(arr);
                for (int left = end - 1; left >= start; left--)
                {
                    for (int right = left + 1; right <= end; right++)
                    {
                        if (arr[left] != arr[right])
                        {
                            Swap(left, right);
                            PermuteRep(arr, left + 1, end);
                        }                    
                    }
                    var firstElement = arr[left];
                    for (int i = left; i <= end - 1; i++)
                      arr[i] = arr[i + 1];
                    arr[end] = firstElement;
                }
            }

            private static void Print(char[] arr)
            {
                Console.WriteLine(String.Join(" ", arr));
            }

            static void Swap(int first, int second)
            {
                char temp = elements[first];
                elements[first] = elements[second];
                elements[second] = temp;
            }
        }
    }

