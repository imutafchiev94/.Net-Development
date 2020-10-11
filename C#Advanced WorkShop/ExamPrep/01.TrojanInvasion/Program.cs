using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TrojanInvasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var platesInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var plates = new Queue<int>();

            for (int i = 0; i < platesInput.Length; i++)
            {
                plates.Enqueue(platesInput[i]);
            }
            

            var warriars = new Stack<int>();

            var w = 0;

            var p = 0;

            var count = 1;

            var plate = 0;

            var warriar = 0;

            while (n != 0)
            {
                var warriarsInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                

                if (count % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                if (plates.Count == 0)
                {
                    break;
                }

                foreach (var war in warriarsInput)
                {
                    warriars.Push(war);
                }

                if(plates.Count == 0)
                {
                    break;
                }
                
                while (warriars.Count != 0 && plates.Count != 0)
                {
                    
                    if(warriar <= 0)
                    {
                        warriar = warriars.Pop();
                    }
                    if(plate <= 0)
                    {
                        plate = plates.Dequeue();
                    }

                    if (warriar < plate)
                    {
                        plate -= warriar;
                        warriar = 0;
                    }
                    else if (warriar > plate)
                    {
                        warriar -= plate;
                        plate = 0;
                    }
                    else if (warriar == plate)
                    {
                        warriar = 0;
                        plate = 0;
                    }
                }

                if(plates.Count == 0)
                {
                    warriars.Push(warriar);
                }

                n--;
                count++;

                if(n == 0 && plate != 0)
                {
                    plates.Enqueue(plate);
                }
            }

            if(plates.Count > 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");

                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");

                Console.WriteLine($"Warriors left: {string.Join(", ", warriars)}");
            }
        }
    }
}
