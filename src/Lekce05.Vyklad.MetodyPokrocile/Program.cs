internal class Program
{
    private static void Main(string[] args)
    {
        //string textOdUzivatele = Console.ReadLine(); // volani metody s vystepem bez vstupnich parametru

        JsemHladovyPoXHodinach(2); // vystup metody zahodim
        bool jsemHladovy = JsemHladovyPoXHodinach(2); // vystup metody ulozim do promenne
        Console.WriteLine($"Jsem hladovy: {jsemHladovy}");
        jsemHladovy = JsemHladovyPoXHodinach(7);
        Console.WriteLine($"Jsem hladovy: {jsemHladovy}");

        int vypocitanyVek = VypocitejMujVek(1990);
        Console.WriteLine($"Tvuj vypocitany vek je {vypocitanyVek}");

        vypocitanyVek = UzivatelZadaSvujRokNarozeniAVypocitaSeJehoVek();
    }

    // Metoda se vstupem a vystupem
    public static bool JsemHladovyPoXHodinach(int pocetHodin)
    {
        if (pocetHodin >= 6)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int VypocitejMujVek(int rokNarozeni)
    {
        int vek = 2025 - rokNarozeni;
        return vek;
        // return 2025 - rokNarozeni;
    }

    public static int UzivatelZadaSvujRokNarozeniAVypocitaSeJehoVek()
    {
        Console.WriteLine("Zadej svuj rok narozeni:");
        string textOdUzivatele = Console.ReadLine();
        int rokNarozeni = int.Parse(textOdUzivatele);
        int vypocitanyVek = 2025 - rokNarozeni;

        Console.WriteLine($"Tvuj vypocitany vek je {vypocitanyVek}");
        return vypocitanyVek;
    }

}
