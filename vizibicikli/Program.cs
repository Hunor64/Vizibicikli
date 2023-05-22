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

            //Hagyományos
            StreamReader sr = new StreamReader(fileLocation);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var mezok = sr.ReadLine().Split(';');
                Kolcsonzes uj = new Kolcsonzes(mezok[0],
                                               mezok[1][0],
                                               int.Parse(mezok[2]),
                                               int.Parse(mezok[3]),
                                               int.Parse(mezok[4]),
                                               int.Parse(mezok[5]));
            }
            sr.Close();

            //ReadAllLines + Foreach, konstruktorban bontom fel
            List<Kolcsonzes> megMasikLista = new List<Kolcsonzes>();
            foreach (var sor in File.ReadAllLines(fileLocation))
            {
                megMasikLista.Add(new Kolcsonzes(sor));
            }

            //ReadAllLines + Foreach, itt bontom fel
            List<Kolcsonzes> megMasikMegintLista = new List<Kolcsonzes>();
            foreach (var sor in File.ReadAllLines(fileLocation))
            {
                var ujMezok = sor.Split(';');
                Kolcsonzes uj = new Kolcsonzes(ujMezok[0],
                                               ujMezok[1][0],
                                               int.Parse(ujMezok[2]),
                                               int.Parse(ujMezok[3]),
                                               int.Parse(ujMezok[4]),
                                               int.Parse(ujMezok[5]));
            }

            //LINQ
            List<Kolcsonzes> masikLista =
            File.ReadAllLines(fileLocation)
                .Skip(1)
                .Select(x => new Kolcsonzes(x))
                .ToList();

            //5. záró
            List<Kolcsonzes> megMasikMegintUjraLista = new List<Kolcsonzes>();
            megMasikMegintUjraLista = File.ReadAllLines(fileLocation)
                                          .Skip(1)
                                          .Select(x => new Kolcsonzes(x))
                                          .ToList();
        }
        private static Kolcsonzes ConvertCSVStringToKolcsonzes(string csvSor)
    }
}
