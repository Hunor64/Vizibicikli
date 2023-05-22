﻿using System;
using System.Collections.Generic;
using System.Text;

namespace vizibicikli
{
    internal class Kolcsonzes
    {
        string nev;
        char jAzon;
        int eOra;
        int ePerc;
        int vOra;
        int vPerc;

        public Kolcsonzes(string nev, char jazon, int eOra, int ePerc, int vOra, int vPerc)
        {
            this.nev = nev;
            this.jAzon = jazon;
            this.eOra = eOra;
            this.ePerc = ePerc;
            this.vOra = vOra;
            this.vPerc = vPerc;
        }

        public string Nev { get => nev; }
        public char Jazon { get => jAzon; }
        public int EOra { get => eOra; }
        public int EPerc { get => ePerc; }
        public int VOra { get => vOra; }
        public int VPerc { get => vPerc; }
    }
}