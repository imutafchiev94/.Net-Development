using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private List<Present> data;

        public Bag(string color, int capacity)
        {
            this.Color = color;

            this.Capacity = capacity;

            this.data = new List<Present>();
        }

        public string Color { get; set; }

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Present present)
        {
            if(this.data.Count < this.Capacity)
            {
                this.data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            var present = this.data.FirstOrDefault(p => p.Name == name);

            if(present != null)
            {
                this.data.Remove(present);
                return true;
            }

            return false;
        }

        public Present GetHeaviestPresent()
        {
            Present heaviestPresent = null;

            int heaviestWeight = 0;

            foreach (var present in this.data)
            {
                if(present.Weight > heaviestWeight)
                {
                    heaviestPresent = present;
                }
            }

            return heaviestPresent;
        }

        public Present GetPresent(string name)
        {
            var present = this.data.FirstOrDefault(p => p.Name == name);

            return present;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Color} bag contains:");
            foreach (var present in this.data)
            {
                sb.AppendLine(present.ToString());
            }

            return sb.ToString();
        }
    }
}
