using System;

internal class Program
{
    /*
     * Níže je uvedeno ukázkové řešení domácího úkolu.
     *
     * TIP: Všechny metody píšeme mimo metodu Main. Každá metoda má tento obecný tvar:
     *
     * public static [NavratovyTyp] [JmenoMetody]([TypParametru1] [JmenoParametru1], ...)
     * {
     *     // Tělo metody
     *     return [Hodnota];
     * }
     *
     * V následující ukázce metody:
     *  NavratovyTyp = string (metoda navrací text)
     *  JmenoMetody = UkazkaMetodySNavratovymTypem (metody nazýváme libovolným textem s velkým počátečním písmenem)
     *  TypParametru1 = string (libovolný datový typ, zde string)
     *  JmenoParametru1 = textVParametru (pod tímto názvem "text" je dodaný parametr dostupný v metodě)
    */
    public static string UkazkaMetodySNavratovymTypem(string textVParametru)
    {
        /// Zde (tělo metody), můžeme pracovat s dodanými parametry (zde string text a double desetinneCislo)
        Console.WriteLine(textVParametru); // můžeme pracovat s parameterem textVParametru

        string promennaObsahujiciLibovolnyText = "Toto je libovolný text";

        // Vracíme hodnotu z metody
        return promennaObsahujiciLibovolnyText; // navrácení hodnoty z metody přes RETURN, musíme vracet hodnotu typu string.
    }

    // TIP: Metody pište mimo Main, například přímo pod tento řádek

    public static string NactiText()
    {
        Console.WriteLine("Zadej libovolný text:");
        string vstupUzivatele = Console.ReadLine();
        return vstupUzivatele;
    }

    public static double NactiDesetinneCislo()
    {
        Console.WriteLine("Zadej libovolné desetinné číslo:");
        string vstupUzivatele = Console.ReadLine();
        double desetinneCislo;
        bool povedloSePrevest = double.TryParse(vstupUzivatele, out desetinneCislo);

        while (povedloSePrevest == false)
        {
            Console.WriteLine("Zadal jsi nesprávně. Zadej libovolné desetinné číslo:");
            vstupUzivatele = Console.ReadLine();
            povedloSePrevest = double.TryParse(vstupUzivatele, out desetinneCislo);
        }
        return desetinneCislo;
    }

    public static string NactiText(string textProUzivatele)
    {
        Console.WriteLine(textProUzivatele);
        string vstupUzivatele = Console.ReadLine();
        return vstupUzivatele;
    }

    public static double NactiDesetinneCislo(string textProUzivatele)
    {
        Console.WriteLine(textProUzivatele);
        string vstupUzivatele = Console.ReadLine();
        double desetinneCislo;
        bool povedloSePrevest = double.TryParse(vstupUzivatele, out desetinneCislo);

        while (povedloSePrevest == false)
        {
            Console.WriteLine($"Zadal jsi nesprávně. {textProUzivatele}");
            vstupUzivatele = Console.ReadLine();
            povedloSePrevest = double.TryParse(vstupUzivatele, out desetinneCislo);
        }
        return desetinneCislo;
    }

    static void Main(string[] args)
    {
        /*
        1) Vytvořte metodu, která se bude uživatele ptát na zadání libovolného textu (string).
        Metoda navrátí tento text jako návratovou hodnotu.
        2) Zavolejte metodu a vypište text, který uživatel zadal.

        3) Vytvořte metodu pro zadání libovolného desetinného čísla(double).
        Dokud uživatel nezadá správně desetinné číslo, nechávejte uživatele pokusit se číslo zadat znovu.
        Jakmile zadá uživatel desetinné číslo správně, metoda jej navrátí toto desetinné číslo jako návratovou hodnotu.
        4) Zavolejte metodu a vypište desetinné číslo, které uživatel zadal.

        Bonus: 5) Přidejte metodám parametr typu string, ve kterém metodě předáte text,
        který se zobrací v konzoli před tím, než se uživatel pokusí zadat svůj vstup.
        6) Zavolejte metody s parametrem a vypište text, který uživatel zadal.
        */

        string vstupText = NactiText();
        Console.WriteLine($"Zadal jsi text: {vstupText}");

        double vstupDesetinneCislo = NactiDesetinneCislo();
        Console.WriteLine($"Zadal jsi desetinné číslo: {vstupDesetinneCislo}");

        string vstupTextBonus = NactiText("Zadej libovolný text pro bonus:");
        Console.WriteLine($"Zadal jsi text pro bonus: {vstupTextBonus}");

        double vstupDesetinneCisloBonus = NactiDesetinneCislo("Zadej libovolné desetinné číslo:");
        Console.WriteLine($"Zadal jsi desetinné číslo pro bonus: {vstupDesetinneCisloBonus}");
    }
}
