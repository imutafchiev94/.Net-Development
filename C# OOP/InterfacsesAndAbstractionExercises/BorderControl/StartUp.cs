using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Citizen> citizens = new List<Citizen>();

            List<Rebel> rebels = new List<Rebel>();

            

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var command = input.Split(" ").ToArray();

                var citizenNames = citizens.Select(c => c.Name);
                var rebelNames = rebels.Select(r => r.Name);


                if (command.Length == 4)
                {

                    string name = command[0];

                    if (!citizenNames.Contains(name) && !rebelNames.Contains(name))
                    {
                        int age = int.Parse(command[1]);

                        string id = command[2];

                        string birthdate = command[3];

                        Citizen citizen = new Citizen(name, age, id, birthdate);

                        citizens.Add(citizen);
                    }

                }
                else if (command.Length == 3)
                {
                    string name = command[0];

                    if (!citizenNames.Contains(name) && !rebelNames.Contains(name))
                    {
                        int age = int.Parse(command[1]);

                        string group = command[2];

                        Rebel rebel = new Rebel(name, age, group);

                        rebels.Add(rebel);
                    }
                }
            }

            var names = Console.ReadLine();

            while(names != "End")
            {
                var citizenNames = citizens.Select(c => c.Name);
                var rebelNames = rebels.Select(r => r.Name);

                if(citizenNames.Contains(names))
                {
                    var citizen = citizens.FirstOrDefault(c => c.Name == names);

                    citizen.BuyFood();
                }
                else if(rebelNames.Contains(names))
                {
                    var rebel = rebels.FirstOrDefault(r => r.Name == names);

                    rebel.BuyFood();
                }

                names = Console.ReadLine();
            }

            var food = 0;

            foreach (var citizen in citizens)
            {
                food += citizen.Food;
            }

            foreach (var rebel in rebels)
            {
                food += rebel.Food;
            }

            Console.WriteLine(food);
        }
    }
}
