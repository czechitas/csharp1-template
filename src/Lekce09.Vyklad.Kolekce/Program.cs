namespace Lekce09.Vyklad.Kolekce;

public class Rytir
{
    public Rytir(string jmeno, int pocetZivotu)
    {
        Jmeno = jmeno;
        PocetZivotu = pocetZivotu;
    }

    private string Jmeno;
    private int PocetZivotu;

    public void PredstavSe()
    {
        Console.WriteLine($"Ja jsem rytir {Jmeno}, mam {PocetZivotu} zivotu.");
    }
}

public class Kun
{
    private string Jmeno;
}

public class Program
{
    static void Main(string[] args)
    {
        Rytir rytir1 = new Rytir("Pepa", 3);
        Rytir rytir2 = new Rytir("Jarmil", 5);
        Rytir rytir3 = new Rytir("Kamil", 2);
        Rytir rytir4 = new Rytir("Petr", 4);

        List<Rytir> rytiriPostupne = new List<Rytir>();
        rytiriPostupne.Add(rytir1);
        rytiriPostupne.Add(rytir2);
        rytiriPostupne.Add(rytir4);

        Console.WriteLine("Vypisuji rytire zadane postupne pres for:");
        for (int i = 0; i < rytiriPostupne.Count; i++)
        {
            rytiriPostupne[i].PredstavSe();
        }

        List<Rytir> rytiriNajednou = new List<Rytir>() { rytir1, rytir3, rytir4 };

        Console.WriteLine("Vypisuji rytire zadane najednou pres foreach:");
        foreach (Rytir rytir in rytiriNajednou)
        {
            rytir.PredstavSe();
        }

        List<int> seznamCisel = new List<int>();
        seznamCisel.Add(5);
        // seznamCisel.Add(rytir1); // nejde
    }
}
