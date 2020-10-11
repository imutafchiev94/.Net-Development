using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Doctor
    {

        public Doctor(string firstName, string sureName)
        {
            this.FirstName = firstName;

            this.SureName = sureName;

            this.Patients = new List<Patient>();
        }

        public string FirstName { get; set; }

        public string SureName { get; set; }

        public List<Patient> Patients { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var patient in this.Patients)
            {
                sb.AppendLine(patient.ToString());
            }

            return sb.ToString();
        }
    }
}
