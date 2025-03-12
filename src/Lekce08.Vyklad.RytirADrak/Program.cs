internal class Program
{
    /*
    Vytvoř třídu Rytíř, který bude mít vlastnosti: jméno, počet životů a sílu
    Ve třídě rytíř vytvoř metodu UtocNaDraka, která na konzoli vypíše "Útočím na draka!"
    Ve třídě rytíř vytvoř metodu PredstavSe, která vypíše informace o rytíři.
    */

    public class Rytir
    {
        public Rytir(string jmeno, int pocetZivotu)
        {
            Jmeno = jmeno;
            PocetZivotu = pocetZivotu;
        }

        public Rytir(string jmeno)
        {
            Jmeno = jmeno;
            PocetZivotu = 5;
        }

        private string Jmeno;
        private int PocetZivotu;

        public void PredstavSe()
        {
            Console.WriteLine($"Ja jsem rytir {Jmeno}, mam {PocetZivotu} zivotu.");
        }

        public void UtocimNaDraka(Drak drak)
        {
            Console.WriteLine($"Utocim na draka {drak.ZiskejJmeno("wouldyoukindly")}");
        }
    }
    /*
    Vytvoř třídu Drak, který bude mít vlastnosti: jméno, počet hlav a silu
    Ve třídě drak vytvoř metodu PredstavSe, která vypíše informace o drakovi.
    Ve třídě drak vytvoř metodu ZasazenRytirem, která drakovi sníží počet hlav o 1 a vypíše, "Kde mám hlavu!" a pokud už jsou všechny hlavy pryč, napíše "Jsem poražen ..."
    */
    public class Drak
    {
        public Drak(string jmeno, int pocetHlav)
        {
            Jmeno = jmeno;
            if (pocetHlav < 1)
            {
                PocetHlav = 1;
            }
            else
            {
                PocetHlav = pocetHlav;
            }
        }
        private string Jmeno;
        private int PocetHlav;

        public string ZiskejJmeno(string heslo)
        {
            if (heslo == "wouldyoukindly")
            {
                return Jmeno;
            }
            return "Unknown";
        }
        public void PredstavSe()
        {
            Console.WriteLine($"Jsem Drak {Jmeno}, mam {PocetHlav} hlav.");
        }

        /*Metoda ZasazenRytirem, která drakovi sníží počet hlav o 1 a vypíše, "Kde mám hlavu!"
         a pokud už jsou všechny hlavy pryč, napíše "Jsem poražen ..."*/
        public void ZasazenRytirem()
        {
            if (PocetHlav > 0)
            {
                Console.WriteLine("Kde mam hlavu?");
                PocetHlav--; //ekvivalentni zapis: PocetHlav = PocetHlav - 1;
            }
            else
            {
                Console.WriteLine("Jsem porazen...");
            }
        }
    }

    private static void Main(string[] args)
    {
        // //1. Naplneni vlastnosti
        // Rytir bonifac = new Rytir(); //vytvoreni instance tridy Rytir
        // // Zmena vlastnasti instance "bonifac"
        // bonifac.PredstavSe();

        // bonifac.Jmeno = "Bonifac";
        // bonifac.PocetZivotu = 5;
        // bonifac.Sila = 3;
        // bonifac.PredstavSe();

        // //2. Object initializer
        // Rytir ferdinand = new Rytir
        // {
        //     Jmeno = "Ferdinand",
        //     PocetZivotu = 4,
        //     Sila = 8,
        // };

        //3. Pouziti konstruktoru
        Rytir konstantin = new Rytir("Konstantin", 10);
        konstantin.PredstavSe();

        Drak trupik = new Drak("Trupik", 0);
        trupik.PredstavSe();

        konstantin.UtocimNaDraka(trupik);
        trupik.ZasazenRytirem();
        trupik.ZasazenRytirem();
        trupik.ZasazenRytirem();
        trupik.ZasazenRytirem();
        trupik.ZasazenRytirem();
    }
}