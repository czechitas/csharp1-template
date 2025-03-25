internal class Program
{
    private static void Main(string[] args)
    {

        Circle kruh1 = new Circle(5);
        Circle kruh2 = new Circle(6);

        Console.WriteLine($"Bylo vytvoreno {Circle.PocetVytvorenychKruhu} kruhu.");

        Circle kruh3 = new Circle(7);
        Circle kruh4 = new Circle(8);

        Console.WriteLine($"Bylo vytvoreno {Circle.PocetVytvorenychKruhu} kruhu.");

        kruh1.VypisPocetKruhu();
        kruh1.VypisInfo();
        kruh3.VypisPocetKruhu();
        kruh3.VypisInfo();
    }

    public class Circle
    {
        public Circle(double polomer)
        {
            Polomer = polomer;
            PocetVytvorenychKruhu++;
            PoradiVytvoreni = PocetVytvorenychKruhu;

            VypisInfo();
        }
        private double Polomer;
        private string Barva;
        private int PoradiVytvoreni;

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

        public void VypisInfo()
        {
            Console.WriteLine($"Jsem kruh s polomerem {Polomer} a byl jsem vytvoren jako {PoradiVytvoreni} kruh v poradi.");
        }

        public void VypisPocetKruhu()
        {
            Console.WriteLine($"Celkem bylo vytvoreni {PocetVytvorenychKruhu} kruhu.");
        }
    }
}
