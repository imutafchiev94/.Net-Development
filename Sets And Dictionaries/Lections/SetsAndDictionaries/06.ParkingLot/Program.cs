using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new HashSet<string>();

            var input = Console.ReadLine().Split(", ").ToArray();

            while(input[0] != "END")
            {
                if(input.Length == 2)
                {
                    var command = input[0];
                    var car = input[1];

                    switch(command)
                    {
                        case "IN":
                            {
                                cars.Add(car);
                                break;
                            }
                        case "OUT":
                            {
                                if(cars.Contains(car))
                                {
                                    cars.Remove(car);
                                }

                                break;
                            }
                    }
                }

                input = Console.ReadLine().Split(", ").ToArray();
            }

            if(cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
