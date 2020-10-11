using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LeutenantGeneral : Private, ILieutenantGeneral
    {
        public LeutenantGeneral(int id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new HashSet<Private>();
        }

        public HashSet<Private> Privates { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {String.Format("{0:0.00}", this.Salary)}");
            if(this.Privates.Count > 0)
            {
                sb.AppendLine("Privates:");
                var count = 1;
                foreach (var solder in this.Privates)
                {
                    if (count < this.Privates.Count)
                    {
                        sb.AppendLine($"  {solder.ToString()}");
                    }
                    else
                    {
                        sb.Append($"  {solder.ToString()}");
                    }
                    count++;
                };
            }
            else
            {
                sb.Append("Privates:");
            }
            

            return sb.ToString();
        }
    }
}
