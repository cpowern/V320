﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Wintergarten: Zimmer
    {
        public double Sonneneinstrahlung {  get; set; }

        public Wintergarten() : base("Wintergarten")
        {

        }

    }
}
