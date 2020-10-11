using System;
using System.Linq;

namespace Vechiles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var cars = Console.ReadLine().Split(" ").ToArray();

            var trucks = Console.ReadLine().Split(" ").ToArray();

            var buses = Console.ReadLine().Split(" ").ToArray();

            double carFuel = 0;

            double truckFuel = 0;

            double busFuel = 0;

            if (double.Parse(cars[1]) > double.Parse(cars[3]))
            {
                carFuel = 0;
            }
            else
            {
                carFuel = double.Parse(cars[1]);
            }
            var car = new Car(carFuel, double.Parse(cars[2]), double.Parse(cars[3]));

            if (double.Parse(trucks[1]) > double.Parse(trucks[3]))
            {
                truckFuel = 0;
            }
            else
            {
                truckFuel = double.Parse(trucks[1]);
            }
            var truck = new Truck(truckFuel, double.Parse(trucks[2]), double.Parse(trucks[3]));

            if (double.Parse(buses[1]) > double.Parse(buses[3]))
            {
                busFuel = 0;
            }
            else
            {
                busFuel = double.Parse(buses[1]);
            }
            var bus = new Bus(busFuel, double.Parse(buses[2]), double.Parse(buses[3]));


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(" ").ToArray();

                if(command[1] == "Car")
                {
                    if(command[0] == "Drive")
                    {
                        car.Drive(double.Parse(command[2]));
                    }
                    else
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                }
                else if(command[1] == "Truck")
                {
                    if (command[0] == "Drive")
                    {
                        truck.Drive(double.Parse(command[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                }
                else
                {
                    if (command[0] == "Drive")
                    {
                        bus.Drive(double.Parse(command[2]));
                    }
                    else if (command[0] == "Refuel")
                    {
                        bus.Refuel(double.Parse(command[2]));
                    }
                    else
                    {
                        bus.DriveEmpty(double.Parse(command[2]));
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
