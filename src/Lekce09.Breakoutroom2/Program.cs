using System;
using System.Collections.Generic;

namespace Lekce09.BreakoutRoom2;

internal class Program
{
    static void Main(string[] args)
    {
        /*
        Příprava:
         - Vytvoř třídu Clovek (vlastnosti Jmeno a Prijmeni, metoda PredstavSe)
         - Vytvoř třídu TelefonniKontakt (vlastnosti Clovek a Cislo, metoda VypisKontakt)

        1. Vytvoř libovolné 3 instance třídy TelefonniKontakt.

        2. Vytvoř kolekci (List) telefonních kontaktů,
           do které přiřaď všechny telefonní kontakty z předchozího bodu.

        3. Vytvoř třídu TelefonniSeznam, která bude mít vlastnost,
           do které se dá uložit kolekce (List) telefonních kontaktů.

        4. Vytvoř instanci třídy TelefonniSeznam a přiřaď její vlastnost
           kolekci telefonních kontaktů vytvořenou v kroku 2.

        5. Třídě TelefonniSeznam přidej metodu VypisKontakty(),
           která pomocí FOR cyklu (s využitím vlastnosti Count) vypíše do konzole informace
           o všech kontaktech v telefonním seznamu.

        6. BONUS: Vytvoř třídě TelefonniSeznam konstruktor,
           jehož parametrem bude kolekce (List) telefonních kontaktů, a ten si v konstruktoru ulož do vlastnosti.
           Změň modifikátor přístupu vlastnosti obsahující kolekci telefonních kontaktů
           na private, aby ji nebylo možné přepsat zvenku.
           Uprav vytváření instance třídy TelefonniSeznam, aby používala tento nový konstruktor.
			Mužeš zkusit výpis přes FOREACH
        */

        TelefonniKontakt kontakt1 = new TelefonniKontakt(
            cislo: "+420 777 123456",
            clovek: new Clovek("Jan", "Novak")
        );
        TelefonniKontakt kontakt2 = new TelefonniKontakt(new Clovek("Petr", "Dvorak"), "+420 606 987654");


    }
}

// Třída Clovek
public class Clovek
{
    public string Jmeno;
    public string Prijmeni;

    public Clovek(string jmeno, string prijmeni)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
    }

    public void PredstavSe()
    {
        Console.WriteLine($"{Jmeno} {Prijmeni}");
    }
}

// Třída TelefonniKontakt
public class TelefonniKontakt
{
    public Clovek Clovek;
    public string Cislo;

    public TelefonniKontakt(Clovek clovek, string cislo)
    {
        Clovek = clovek;
        Cislo = cislo;
    }

    public void VypisKontakt()
    {
        Console.WriteLine($"{Clovek.Jmeno} {Clovek.Prijmeni}, telefon: {Cislo}");
    }
}

// Třída TelefonniSeznam
public class TelefonniSeznam
{
    public List<TelefonniKontakt> TelefonniKontakty;
}
