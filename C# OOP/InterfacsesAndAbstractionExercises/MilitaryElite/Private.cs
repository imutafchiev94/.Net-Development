using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Private : Soldier, IPrivate
    {

        public Private(int id, string firstName, string lastName, double salary)
            :base (id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {String.Format("{0:0.00}", this.Salary)}";
        }
    }
}
