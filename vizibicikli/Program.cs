using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace vizibicikli
{
    internal class Program
    {
        static List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();
        static void Main(string[] args)
        {
            string fileLocation = "DataSource\\kolcsonzesek.txt";

            List<Kolcsonzes> megMasikLista = new List<Kolcsonzes>();
            foreach (var sor in File.ReadAllLines(fileLocation))
            {
                megMasikLista.Add(new Kolcsonzes(sor));
            }
        }
    }
}
