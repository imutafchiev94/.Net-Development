using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStationRecruitment
{
    public class Astronaut
    {
        public Astronaut(string name, int age, string contry)
        {
            this.Name = name;
            this.Age = age;
            this.Contry = contry;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Contry { get; set; }


        public override string ToString()
        {
            return $"Astronaut: {this.Name}, {this.Age} ({this.Contry})";
        }
    }
}
