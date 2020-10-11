﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Patient
    {

        public string Name { get; set; }

        public Patient(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {

            return $"{this.Name}";
        }
    }
}
