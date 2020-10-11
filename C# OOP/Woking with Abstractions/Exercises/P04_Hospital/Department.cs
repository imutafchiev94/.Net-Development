using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Department
    {

        public Department(string name)
        {
            this.Name = name;

            this.Capacity = 20;

            this.Rooms = new List<Room>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Room> Rooms { get; set; }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            foreach (var room in this.Rooms)
            {
                if(room.Patients.Count > 0)
                {
                    sb.Append(room.ToString());
                }
            }

            return sb.ToString().Trim();
        }
    }
}
