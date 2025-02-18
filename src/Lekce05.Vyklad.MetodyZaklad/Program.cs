internal class Program
{
    private static void Main(string[] args)
    {
        Zastekej();
        Zastekej();
        Zastekej();

        Zastekej(5);

        int celeCislo = 5;
        string text = "LibovolnyText";

        Console.WriteLine(celeCislo);
        Console.WriteLine(text);
    }

    //Metoda bez parametru a bez navratove hodnoty
    public static void Zastekej()
    {
        Console.WriteLine("Haf!");
    }

    public static void Zastekej(int kolikrat)
    {
        Console.WriteLine($"Zastekej {kolikrat}x!");
        for (int i = 0; i < kolikrat; i++)
        {
            Zastekej();
        }
    }
}
