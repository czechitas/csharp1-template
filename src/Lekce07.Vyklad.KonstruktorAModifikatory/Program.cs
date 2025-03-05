namespace Lekce07.Vyklad.Konstruktor;

class BankovniUcet
{
    public BankovniUcet()
    {
        // konstruktor bez parametru - nastavim svoje vychozi hodnoty
        Majitel = "Neznamy";
        CisloUctu = 0;
    }

    public BankovniUcet(string jmenoMajitele)
    {
        Majitel = jmenoMajitele;
        CisloUctu = 1234657;
    }

    public BankovniUcet(string jmenoMajitele, int cisloUctu)
    {
        Majitel = jmenoMajitele;
        CisloUctu = cisloUctu;
    }

    public int CisloUctu;
    private string Majitel;
    public double Zustatek;

    public string VratMajitele()
    {
        return Majitel;
    }

    public void PrevedUcet(string novyMajitel)
    {
        if (ZkontrolujPrevod(novyMajitel))
        {
            Majitel = novyMajitel;
        }
    }

    bool ZkontrolujPrevod(string novyMajitel)
    {
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankovniUcet ucetInkognito = new BankovniUcet();
        ucetInkognito.PrevedUcet("Jirka");

        Console.WriteLine(ucetInkognito.VratMajitele());

        BankovniUcet ucetJan = new BankovniUcet("Jan Novak");

        BankovniUcet ucetPepa = new BankovniUcet("Josef Novak", 987654);
    }
}

