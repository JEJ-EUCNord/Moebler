﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moebler
{
    internal class Moebel
    {
        public double Pris;
        public String Fabrikant = String.Empty;

        public Moebel(double pris, String fabrikant)
        {
            Pris = pris;
            Fabrikant = fabrikant;
        }

        public virtual void Udskriv()
        {
            Console.WriteLine($"Koster: {Pris} - Lavet af: {Fabrikant}");
        }
    }
}
