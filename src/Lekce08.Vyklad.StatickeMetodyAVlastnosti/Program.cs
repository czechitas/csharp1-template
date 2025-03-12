internal class Program
{


    public static int NactiCeleCisloOdUzivatele()
    {
        Console.WriteLine("Zadej cele cislo:");
        string vstupUzivatele = Console.ReadLine();
        int prevedenyVstup;
        bool povedloSePrevest = int.TryParse(vstupUzivatele, out prevedenyVstup);

        while (!povedloSePrevest)
        {
            Console.WriteLine("Zadej cele cislo:");
            vstupUzivatele = Console.ReadLine();
            povedloSePrevest = int.TryParse(vstupUzivatele, out prevedenyVstup);
        }

        return prevedenyVstup;
    }
    private static void Main(string[] args)
    {
        int vysledek = MatematickeOperace.Secti(5, 4);
        Console.WriteLine(vysledek);

        int prvniCislo = NactiCeleCisloOdUzivatele();

        // Rytir bonifac = new Rytir();
        // bonifac.UtocNaDraka();

        //Nelze vytvaret instance statickych trid
        //MatematickeOperace matematickeOperace = new MatematickeOperace();
        vysledek = MatematickeOperace.NaDruhou(4);
        Console.WriteLine(vysledek);

        Circle kruh = new Circle(5);
        double obvodMehoKruhu = kruh.VratObvod();
        Console.WriteLine(obvodMehoKruhu);

        double vypocitanyObvodZPolomeru = Circle.VypocitejObvodZPolomeru(8);
        Console.WriteLine(vypocitanyObvodZPolomeru);

        Console.WriteLine("Toto je volani staticke metody Console.WriteLine");


        Circle kruh1 = new Circle(5);
        Circle kruh2 = new Circle(6);
        Circle kruh3 = new Circle(7);
        Circle kruh4 = new Circle(8);

    }

    public static class MatematickeOperace
    {
        public static int Secti(int prvniCislo, int druheCislo)
        {
            return prvniCislo + druheCislo;
        }

        public static int NaDruhou(int cislo)
        {
            return cislo * cislo;
        }
    }

    public class Circle
    {
        public Circle(double polomer)
        {
            Polomer = polomer;
            PocetVytvorenychKruhu++;
        }
        private double Polomer;
        public static int PocetVytvorenychKruhu;

        //Vrati Obvod vytvorene instance objektu
        public double VratObvod()
        {
            return 2 * Math.PI * Polomer;
        }
        // Staticka metoda, k dispozici bez instance objektu
        public static double VypocitejObvodZPolomeru(int jakykolivPolomer)
        {
            return 2 * Math.PI * jakykolivPolomer;
        }
    }

    class JablkaGala
    {
        public static string JmenoOdrudy = "Gala";
        public static string Barva = "Červená";
    }
}