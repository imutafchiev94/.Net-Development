using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Room
    {
        public Room(int id)
        {
            this.Id = id;

            this.Capacity = 3;

            this.Patients = new List<Patient>();
        }

        public int Id { get; set; }
        public int Capacity { get; set; }

        public List<Patient> Patients { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var patient in this.Patients)
            {
                sb.AppendLine(patient.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
