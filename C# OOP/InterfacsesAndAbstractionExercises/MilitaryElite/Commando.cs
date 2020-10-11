using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new HashSet<Mission>();
        }

        public HashSet<Mission> Missions { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {String.Format("{0:0.00}", this.Salary)}");
            sb.AppendLine($"Corps: {this.Corps}");
            if (this.Missions.Count > 0)
            {
                sb.AppendLine("Missions:");
                var count = 1;
                foreach (var mission in this.Missions.Where(m => m.State == "inProgress"))
                {
                    if (count < this.Missions.Where(m => m.State == "inProgress").Count())
                    {
                        sb.AppendLine($"{mission.ToString()}");
                    }
                    else
                    {
                        if (mission.State != "finished")
                        {
                            sb.Append($"{mission.ToString()}");
                        }
                    }
                    count++;
                };
            }
            else
            {
                sb.Append("Missions:");
            }

            return sb.ToString();
        }
    }
}
