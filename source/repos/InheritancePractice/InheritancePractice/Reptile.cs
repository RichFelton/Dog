﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Reptile : Species
    {
        public Reptile(double height, double weight, string name, string habitat, bool hasTail)
        {
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Habitat = habitat;
            this.HasTail = hasTail;


        }



        public Reptile()
        {

        }
         

    }
}
