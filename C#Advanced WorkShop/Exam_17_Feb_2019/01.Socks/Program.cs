using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            var leftInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> leftSocks = new Stack<int>();

            var rightInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> rightSocks = new Stack<int>();

            for (int left = 0; left < leftInput.Length; left++)
            {
                leftSocks.Push(leftInput[left]);
            }

            for (int right = rightInput.Length - 1; right >= 0 ; right--)
            {
                rightSocks.Push(rightInput[right]);
            }

            Queue<int> sockPairs = new Queue<int>();

            while(leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                var leftSock = leftSocks.Pop();

                var rightSock = rightSocks.Pop();

                if(leftSock > rightSock)
                {
                    var pair = rightSock + leftSock;

                    sockPairs.Enqueue(pair);
                }
                else if(rightSock > leftSock)
                {
                    rightSocks.Push(rightSock);
                }
                else if(rightSock == leftSock)
                {
                    leftSock++;
                    leftSocks.Push(leftSock);
                }
            }

            var socks = sockPairs.OrderByDescending(x => x);

            Console.WriteLine(socks.First());

            Console.WriteLine(string.Join(" ", sockPairs));
        }
    }
}
