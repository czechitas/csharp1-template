// Výpočet ceny nápoje:

// Pomocí Console.WriteLine Vypiš do konzole výzvu pro uživatele, aby zadal cenu nápoje.
// Cena by měla být zadaná jako číslo s plovoucí desetinnou tečkou (například 1.5 pro Kávu).
// Načti si uživatelský vstup pomocí Console.ReadLine() a ulož ho do proměnné vstupCenaNapoje.

// Použití double.TryParse:
// Vytvořte proměnnou cenaNapoje typu double pro uložení výsledku převodu.
// Použijte metodu double.TryParse s uživatelským vstupem vstupCenaNapoje a proměnnou cenaNapoje.
// double.TryParse vrátí boolovskou hodnotu, kterou uložte do proměnné jeCenaPlatna.

// Výpočet celkové ceny:
// Pokud byl vstup úspěšně převeden (jeCenaPlatna je true), vypiš do konzole výzvu pro zadání počtu nápojů.
// Použij int.TryParse pro převod počtu nápojů na číslo a ulož výsledek do proměnné pocetNapoju.
// Vypočítej celkovou cenu (cena nápoje * počet nápojů) a vypiš výsledek.
// Pokud nebyl vstup úspěšně převeden, vypiš varovnou zprávu o neplatném zadání ceny.

Console.WriteLine("Cena napoju");
Console.WriteLine("Zadej cenu napoje i s plovouci desetinnou teckou - napr. 1.5 pro Kavu");

string vstupCenaNapoje = Console.ReadLine();

double cenaNapoje;
bool jeCenaPlatna = double.TryParse(vstupCenaNapoje, out cenaNapoje);

if (jeCenaPlatna)
{
    Console.WriteLine("Zadej pocet napoju:");
    int pocetNapoju;
    string vstupPocetNapoju = Console.ReadLine();
    bool jePocetPlatny = int.TryParse(vstupPocetNapoju, out pocetNapoju);

    if (jePocetPlatny)
    {
        double celkovaCena = pocetNapoju * cenaNapoje;
        Console.WriteLine($"Celkova cena je {celkovaCena}");
    }
    else
    {
        Console.WriteLine($"Neplatny pocet. Nedokázal jsem převést text {vstupPocetNapoju} na celé číslo.");
    }
}
else
{
    Console.WriteLine(
        $"Zadana spatna cena :( Nedokázal jsem převést text {vstupCenaNapoje} na desetinné číslo.");
}

// Alternativne s poizitim return

Console.WriteLine("Cena napoju");
Console.WriteLine("Zadej cenu napoje i s plovouci desetinnou teckou - napr. 1.5 pro Kavu");

string vstupCenaNapoje2 = Console.ReadLine();

double cenaNapoje2;
bool jeCenaPlatna2 = double.TryParse(vstupCenaNapoje2, out cenaNapoje2);

if (!jeCenaPlatna2)
{
    Console.WriteLine(
        $"Zadana spatna cena :( Nedokázal jsem převést text {vstupCenaNapoje2} na desetinné číslo.");
    return;
}

Console.WriteLine("Zadej pocet napoju:");
int pocetNapoju2;
string vstupPocetNapoju2 = Console.ReadLine();
bool jePocetPlatny2 = int.TryParse(vstupPocetNapoju2, out pocetNapoju2);

if (!jePocetPlatny2)
{
    Console.WriteLine($"Neplatny pocet. Nedokázal jsem převést text {vstupPocetNapoju2} na celé číslo.");
    return;
}

double celkovaCena2 = pocetNapoju2 * cenaNapoje2;
Console.WriteLine($"Celkova cena je {celkovaCena2}");



