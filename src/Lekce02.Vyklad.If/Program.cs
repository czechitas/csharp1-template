// Práce s IFem
int vek = 17;

Console.WriteLine("Kod pred Ifem.");
string hlaskaDoKonzole = "Zatim neznama plnoletost.";

if (vek >= 18) // POKUD
{
    // Vetev1 - podminka splnena
    hlaskaDoKonzole = "Jsi plnolety.";
}
else if (vek <= 6) // JINAK POKUD
{
    hlaskaDoKonzole = "Jsi dite.";
}
else if (vek == 17) // JINAK POKUD
{
    hlaskaDoKonzole = "Je ti prave 17 let.";
}
else // JINAK - nepovinna
{
    // Vetev2 - podminka nesplnena
    hlaskaDoKonzole = "Jsi neplnolety.";
}

Console.WriteLine(hlaskaDoKonzole);

Console.WriteLine("Kod za Ifem.");

// int Parse
Console.WriteLine("Zadej svuj vek:");
string vstupUzivateleVek = Console.ReadLine();
int vekUzivatele = int.Parse(vstupUzivateleVek);
Console.WriteLine("Tvuj vek je: " + vekUzivatele);

// double Parse
Console.WriteLine("Zadej svoji vahu:");
string vstupUzivateleVaha = Console.ReadLine();
double vahaUzivatele = double.Parse(vstupUzivateleVaha);
Console.WriteLine("Tva vaha je: " + vahaUzivatele);
