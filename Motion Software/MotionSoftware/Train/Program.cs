using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> trains = new Dictionary<string, int>();
            Dictionary<string, int> trainPassangers = new Dictionary<string, int>();

            string[] stringSeperator = { "->", ":" };

            var input = Console.ReadLine().Split(stringSeperator, StringSplitOptions.RemoveEmptyEntries).ToList();


            while(input[0] != "Slide rule")
            {
                if(input[1] != "ambush")
                {
                    string town = input[0];
                    int time = int.Parse(input[1]);
                    int passangers = int.Parse(input[2]);

                    if(!trains.Keys.Contains(town))
                    {                        
                        trains[town] = time;
                        trainPassangers[town] = passangers;
                    }
                    else if(trains.Keys.Contains(town))
                    {
                        if(trains[town] > time || trains[town] <= 0)
                        { 
                            int passanger = trainPassangers[town] + passangers;

                            trains[town] = time;
                            trainPassangers[town] = passanger;
                        }

                        else
                        {
                            trainPassangers[town] += passangers;
                        }
                        
                    }

                }

                if(input[1] == "ambush")
                {
                    string town = input[0];
                    int passangers = int.Parse(input[2]);


                    if (trains.Keys.Contains(town))
                    {
                        trains[town] = 0;

                        trainPassangers[town] -= passangers;
                    }
                }

                input = Console.ReadLine().Split(stringSeperator, StringSplitOptions.RemoveEmptyEntries).ToList();
            }


            foreach (var train in trains.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                if (train.Value != 0 || trainPassangers[train.Key] != 0)
                {
                    Console.WriteLine($"{train.Key} -> Time: {train.Value} -> Passengers: {trainPassangers[train.Key]}");
                }
            }
        }
    }
}
