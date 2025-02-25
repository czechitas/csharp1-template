internal class Program
{
    private static void Main(string[] args)
    {
        // toto se zapomene
        VypocitejMujVek(1975);
        // vysledek volani si musim ulozit do promenne
        int mujVek = UzivatelZadaSvujRokNarozeniAVypocitaSeJehoVek();
        Console.WriteLine($"Muj vek je {mujVek}.");
    }

    public static int VypocitejMujVek(int rokNarozeni)
    {
        int vek = 2025 - rokNarozeni;
        return vek;
    }

    public static int UzivatelZadaSvujRokNarozeniAVypocitaSeJehoVek()
    {
        Console.WriteLine("Napis rok narozeni");
        string text = Console.ReadLine();
        int rokNarozeni = int.Parse(text);
        int vek = VypocitejMujVek(rokNarozeni);
        return vek;
    }

}
