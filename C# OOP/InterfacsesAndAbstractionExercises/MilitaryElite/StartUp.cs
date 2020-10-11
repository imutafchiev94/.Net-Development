using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").ToArray();

            List<Soldier> soldiers = new List<Soldier>();
            List<Private> privates = new List<Private>();

            while(input[0] != "End")
            {
                switch(input[0])
                {
                    case "Private":
                        {
                            int id = int.Parse(input[1]);
                            string firstName = input[2];
                            string lastName = input[3];
                            double salary = double.Parse(input[4]);

                            Private soldier = new Private(id, firstName, lastName, salary);
                            soldiers.Add(soldier);
                            privates.Add(soldier);

                            break;
                        }
                    case "Commando":
                        {
                            int id = int.Parse(input[1]);
                            string firstName = input[2];
                            string lastName = input[3];
                            double salary = double.Parse(input[4]);
                            string cops = input[5];

                            if(cops == "Airforces" || cops == "Marines")
                            {
                                Commando soldier = new Commando(id, firstName, lastName, salary, cops);

                                for (int i = 6; i < input.Length; i += 2)
                                {
                                    if(input[i + 1] == "inProgress" || input[i + 1] == "finished")
                                    {
                                        Mission mission = new Mission(input[i], input[i + 1]);

                                        soldier.Missions.Add(mission);
                                    }
                                    
                                }
                                soldiers.Add(soldier);
                            }
                                

                            break;
                        }
                    case "Spy":
                        {
                            int id = int.Parse(input[1]);
                            string firstName = input[2];
                            string lastName = input[3];
                            int codeNumber = int.Parse(input[4]);

                            Spy spy = new Spy(id, firstName, lastName, codeNumber);

                            soldiers.Add(spy);

                            break;
                        }
                    case "LieutenantGeneral":
                        {
                            int id = int.Parse(input[1]);
                            string firstName = input[2];
                            string lastName = input[3];
                            double salary = double.Parse(input[4]);


                            LeutenantGeneral soldier = new LeutenantGeneral(id, firstName, lastName, salary);

                            for (int i = 5; i < input.Length; i++)
                            {
                                Private solderToAdd = privates.FirstOrDefault(s => s.Id == int.Parse(input[i]));


                                soldier.Privates.Add(solderToAdd);
                            }
                            soldiers.Add(soldier);

                            break;
                        }
                    case "Engineer":
                        {
                            int id = int.Parse(input[1]);
                            string firstName = input[2];
                            string lastName = input[3];
                            double salary = double.Parse(input[4]);
                            string cops = input[5];

                            Engineer soldier = new Engineer(id, firstName, lastName, salary, cops);

                            for (int i = 6; i < input.Length; i += 2)
                            {
                                Repear repear = new Repear(input[i], int.Parse(input[i + 1]));

                                soldier.Repears.Add(repear);
                            }
                            soldiers.Add(soldier);

                            break;
                        }
                }

                input = Console.ReadLine().Split(" ").ToArray();
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }
    }
}