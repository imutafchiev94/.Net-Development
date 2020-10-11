using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {

        public SpaceStation(string name, int capacity)
        {
            this.Capacity = capacity;

            this.Name = name;

            this.data = new List<Astronaut>();
        }

        private List<Astronaut> data { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.data.Count();
            }
        }

        public void Add(Astronaut astronaut)
        {
            if(this.data.Count < this.Capacity)
            {
                this.data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            foreach (var item in this.data)
            {
                if(item.Name == name)
                {
                    this.data.Remove(item);

                    return true;
                }
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            var astronaut = this.data.OrderByDescending(x => x.Age).First();

            return astronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            var astronaut = this.data.FirstOrDefault(x => x.Name == name);

            return astronaut;
        }

        public string Report()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (var astronaut in this.data)
            {
                builder.AppendLine(astronaut.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
