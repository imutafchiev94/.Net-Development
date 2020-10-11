using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Repear : IRepear
    {
        public Repear(string partName, int hoursWorked )
        {
            this.PartName = partName;

            this.HoursWorked = hoursWorked;
        }

        public string PartName { get; set; }
        public int HoursWorked { get; set; }


        public override string ToString()
        {
            return $"  Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}
