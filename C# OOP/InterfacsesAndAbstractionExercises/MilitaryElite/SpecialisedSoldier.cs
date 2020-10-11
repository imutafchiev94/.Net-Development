using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, double salary,string corps)
            :base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps { get; set; }
    }
}
