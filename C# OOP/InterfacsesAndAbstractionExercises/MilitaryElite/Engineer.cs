using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {

        public Engineer(int id, string firstName, string lastName, double salary, string corps)
            :base(id, firstName, lastName, salary, corps)
        {
            this.Repears = new HashSet<Repear>();
        }
        public HashSet<Repear> Repears { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {String.Format("{0:0.00}", this.Salary)}");
            sb.AppendLine($"Corps: {this.Corps}");
            if (this.Repears.Count > 0)
            {
                sb.AppendLine("Repairs:");
                var count = 1;
                foreach (var repear in this.Repears)
                {
                    if (count < this.Repears.Count)
                    {
                        sb.AppendLine($"{repear.ToString()}");
                    }
                    else
                    {
                        sb.Append($"{repear.ToString()}");
                    }
                    count++;
                };
            }
            else
            {
                sb.Append("Repairs:");
            }

            return sb.ToString();
        }
    }
}
