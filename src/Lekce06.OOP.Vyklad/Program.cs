namespace Lekce06.OOP.Vyklad;

using System;

internal class Program
{
    class Auto
    {
        public string Vyrobce;
        public int PocetSedadel;
        public int RokVyroby;
        public string Barva;
        public bool MaSpecialniDisky;

        public void PopisSe()
        {
            Console.WriteLine($"Na sklade mam {Vyrobce}, pocet sedadel {PocetSedadel}, rok vyroby {RokVyroby} a barvy {Barva}. Mam specialni disky : {MaSpecialniDisky}.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Auto ferrari = new Auto();
        ferrari.Vyrobce = "Ferrari";
        ferrari.PocetSedadel = 2;
        ferrari.RokVyroby = 2012;
        ferrari.Barva = "Cervena";
        ferrari.MaSpecialniDisky = true;

        /*
        string ferrariVyrobce = "Ferrari";
        int ferrariPocetSedadel = 2;
        int ferrariRokVyroby = 2012;
        string ferrariBarva = "Cervena";
        */

        //Console.WriteLine($"Na sklade mam {ferrari.Vyrobce}, pocet sedadel {ferrari.PocetSedadel}, rok vyroby {ferrari.RokVyroby} a barvy {ferrari.Barva}");
        ferrari.PopisSe();

        /*
        string skodaVyrobce = "Skoda";
        int skodaPocetSedadel = 4;
        int skodaRokVyroby = 2013;
        string skodaBarva = "Cerna";

        Console.WriteLine($"Na sklade mam {skodaVyrobce}, pocet sedadel {skodaPocetSedadel}, rok vyroby {skodaRokVyroby} a barvy {skodaBarva}");
        */

        Auto skoda = new Auto();
        skoda.Vyrobce = "Skoda";
        skoda.PocetSedadel = 4;
        skoda.RokVyroby = 2015;
        skoda.Barva = "Cerna";

        skoda.PopisSe();

        Console.WriteLine(default(int));
        Console.WriteLine(default(bool));
        Console.WriteLine(default(string));
    }
}
