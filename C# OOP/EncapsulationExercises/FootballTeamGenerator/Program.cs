using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(";").ToArray();

            List<Team> teams = new List<Team>();

            while(command[0] != "END")
            {
                switch(command[0])
                {
                    case "Team":
                        {
                            try
                            {
                                var team = new Team(command[1]);

                                teams.Add(team);
                            }
                            catch (ArgumentException ae)
                            {
                                Console.WriteLine(ae.Message);
                            }

                            break;
                        }
                    case "Add":
                        {
                            var teamName = command[1];

                            var team = teams.FirstOrDefault(t => t.Name == teamName);
                             
                            if(team == null)
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            else

                            {
                                try
                                {
                                    team.AddPlayer(command[2], int.Parse(command[3]), int.Parse(command[4]),
                                    int.Parse(command[5]), int.Parse(command[6]), int.Parse(command[7]));
                                }
                                catch (ArgumentException ae)
                                {
                                    Console.WriteLine(ae.Message);
                                }
                            }

                            break;
                        }
                    case "Remove":
                        {
                            var teamName = command[1];

                            var team = teams.FirstOrDefault(t => t.Name == teamName);

                            if (team == null)
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            else
                            {
                                team.RemovePlayer(command[2]);
                            }

                            break;
                        }
                    case "Rating":
                        {
                            var teamName = command[1];

                            var team = teams.FirstOrDefault(t => t.Name == teamName);

                            if (team == null)
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            else
                            {
                                team.Rating();
                            }

                            break;
                        }
                }

                command = Console.ReadLine().Split(";").ToArray();
            }
        }
    }
}
