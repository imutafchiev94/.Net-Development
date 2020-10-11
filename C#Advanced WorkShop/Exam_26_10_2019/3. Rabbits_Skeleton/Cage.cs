using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {

        private List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            this.Name = name;

            this.Capacity = capacity;

            this.data = new List<Rabbit>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Rabbit rabbit)
        {
            if(data.Count < this.Capacity)
            {
                this.data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            var rabbitToRemove = this.data.FirstOrDefault(r => r.Name == name);

            if(rabbitToRemove != null)
            {
                this.data.Remove(rabbitToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveSpecies(string species)
        {
            var indexes = new List<int>();


            for (int i = 0; i < this.data.Count; i++)
            {
                if(data[i].Species == species)
                {
                    indexes.Add(i);
                }
            }

            foreach (var index in indexes)
            {
                this.data.RemoveAt(index);
            }

        }

        public Rabbit SellRabbit(string name)
        {
            var rabbit = this.data.FirstOrDefault(r => r.Name == name);

            rabbit.Available = false;

            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var indexes = new List<int>();

            var rabbits = new List<Rabbit>();

            for (int i = 0; i < this.data.Count; i++)
            {
                if (data[i].Species == species)
                {
                    indexes.Add(i);
                }
            }

            foreach (var index in indexes)
            {
                this.data[index].Available = false;
                rabbits.Add(this.data[index]);
            }

            return rabbits.ToArray();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rabbits available at { this.Name}:");
            foreach (var rabbit in this.data)
            {
                if (rabbit.Available == true)
                {
                    sb.AppendLine(rabbit.ToString());
                }
            }

            return sb.ToString();
        }
    }
}
