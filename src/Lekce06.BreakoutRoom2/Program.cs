namespace Lekce06.BreakoutRoom1
{
    // Úkol: Třída Clovek
    // --------------------------------------------
    // Vytvořte třídu Clovek, která bude obsahovat následující vlastnosti:
    //   - jméno (string)
    //   - pohlaví (string)
    //   - rok narození (int)
    //   - hmotnost (double)
    //   - v manželství (bool)
    //
    // Dále proveďte následující kroky:
    //   1. Vytvořte dvě instance třídy Clovek a naplňte je daty.
    //   2. Vypište informace o těchto instancích na konzoli .
    //      (zatím pouze pomocí Console.WriteLine v metodě Main)

    class Clovek
    {
        public string Jmeno;
        public string Pohlavi;
        public int RokNarozeni;
        public double Hmotnost;
        public bool VManzelstvi;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Clovek petr = new Clovek();
            petr.Jmeno = "Petr";
            petr.Pohlavi = "Muz";
            petr.RokNarozeni = 1980;
            petr.Hmotnost = 80;
            petr.VManzelstvi = true;

            Console.WriteLine($"Clovek {petr.Jmeno}, pohlavi {petr.Pohlavi}, rok narozeni {petr.RokNarozeni}, hmotnost {petr.Hmotnost}, je {petr.VManzelstvi}");

            Clovek jana = new Clovek();
            jana.Jmeno = "Jana";
            jana.Pohlavi = "Zena";
            jana.RokNarozeni = 2000;
            jana.Hmotnost = 65;
            jana.VManzelstvi = false;

            Console.WriteLine($"Clovek {jana.Jmeno}, pohlavi {jana.Pohlavi}, rok narozeni {jana.RokNarozeni}, hmotnost {jana.Hmotnost}, je {jana.VManzelstvi}");
        }
    }
}
