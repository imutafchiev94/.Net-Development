﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Mammal : Animal
    {

        protected string LivingRegion;

        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {

            this.LivingRegion = livingRegion;

        }
    }
}
