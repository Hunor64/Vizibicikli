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
            int index = 0;
            foreach (var sor in File.ReadAllLines(fileLocation))
            {
                if (index != 0){megMasikLista.Add(new Kolcsonzes(sor));}index++;
            }
            Console.WriteLine("5. Feladat: Napi kölcsönzések száma:",kolcsonzesek.Count);

            Console.Write("6. Feladat: Kérek egy nevet: ");
            string nev = "Kata";
            Console.WriteLine(nev);
            if (kolcsonzesek.Count(x => x.Nev == nev)==0)
            {
                Console.WriteLine("Nem volt ilyen nevű kölcsönző!");
            }
            else
            {
                Console.WriteLine($"\t{nev} kölcsönzései:");
                foreach (var aktKolcsonzes in kolcsonzesek.Where(x => x.Nev == nev))
                {
                    Console.WriteLine($"\t{aktKolcsonzes.EOra}:{aktKolcsonzes.EPerc} - {aktKolcsonzes.VOra}:{aktKolcsonzes.VPerc}");
                }
                
            }
            //8.
            Console.WriteLine("8. Feladat: A napi bevétel:", kolcsonzesek.Sum(ob => ob.idoHossz()) / 30 + 1);

            //10.
            kolcsonzesek.GroupBy(x => x.Jazon).ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Count()}"));
            
        }
    }
}
