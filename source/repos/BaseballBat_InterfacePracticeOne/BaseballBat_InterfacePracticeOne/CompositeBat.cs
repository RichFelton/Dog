﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballBat_InterfacePracticeOne
{
    public class CompositeBat : IBaseballBat
    {
            public int WeightInGrams { get; set; }

            public void Swing()
            {
                Console.WriteLine("Pop!");

            }
    }
}
