using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            var reg = new Regex(@"[a-z]");

            int index = input.Length - 1;

            var hall = "";
            var reservation = 0;

            var halls = new Queue<string>();
            List<int> reservations = new List<int>();

            int hallCapacity = 0;

            while (index != -1)
            {
                if(reg.IsMatch(input[index].ToLower()))
                {
                    hall = input[index];
                    halls.Enqueue(hall);
                }
                else
                {
                    if(halls.Count != 0)
                    {
                        reservation = int.Parse(input[index]);
                    }

                    if (halls.Count != 0 && reservation != 0)
                    {
                        if (hallCapacity + reservation <= capacity)
                        {
                            hallCapacity += reservation;
                            reservations.Add(reservation);
                        }

                        else
                        {
                            Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", reservations)}");

                            if (halls.Count > 0)
                            {
                                reservations = new List<int>() { reservation };

                                hallCapacity = reservation;
                            }
                            else
                            {
                                reservations = new List<int>();

                                hallCapacity = 0;
                            }
                            
                        }
                    }
                }

                index--;
            }
        }
    }
}
