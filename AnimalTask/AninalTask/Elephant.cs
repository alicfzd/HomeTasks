﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTask
{
    public class Elephant : Animal
    {
        public double Weight { get; set; }
        public bool IsTrained { get; set; }

        public override void Hunt<T>(T animal)
        {
           // Elephant hecneyi ovlaya bilmir 
        }

    }
}
