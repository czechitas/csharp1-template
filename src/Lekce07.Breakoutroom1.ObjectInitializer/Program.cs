using System;

//1. Vytvořte třídu Bod, která bude obsahovat souřadnici X a Y.
//    Vytvořte instanci této třídy, naplňte X a Y hodnotami a potom je vytiskněte na konzoli
//2. Ve třídě Bod vytvořte metodu ZobrazInformace,
//    která zobrazí hodnoty např. pro X=1 a Y=2 ve formátu "X: 1, Y: 2"
//3. Vytvořte třídu Usecka, ve které budou dva body A a B.
//4. V programu si vytvořte instanci Usecka, nastavte jí body A a B
//  s libovolnými souřadnicemi (každý bod jiné).
//5. Vytvořte konstruktory pro Bod i Usecku

class Bod
{
    public int X { get; set; }
    public int Y { get; set; }

    public Bod(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void ZobrazInformace()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}

class Usecka
{
    public Bod A { get; set; }
    public Bod B { get; set; }

    public Usecka(Bod a, Bod b)
    {
        A = a;
        B = b;
    }
}

class Program
{
    static void Main()
    {
        // Vytvoření instance bodu
        Bod osamelyBod = new Bod(4, 3);
        osamelyBod.ZobrazInformace();

        // Vytvoření instance úsečky
        Usecka usecka = new Usecka(new Bod(1, 2), new Bod(5, 3));

        // Zobrazení informací o bodech úsečky
        Console.WriteLine("Bod A úsečky:");
        usecka.A.ZobrazInformace();

        Console.WriteLine("Bod B úsečky:");
        usecka.B.ZobrazInformace();
    }
}
