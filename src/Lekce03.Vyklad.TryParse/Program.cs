Console.WriteLine("Zadej cele cislo");
string vstupUzivatele = Console.ReadLine();

//int cislo = int.Parse(vstupUzivatele); // pokusi se prevest string na cislo, pokud se to nepovede, vyhodi vyjimku a program spadne
int cislo;
bool povedloSePrevest = int.TryParse(vstupUzivatele, out cislo); // pokusi se prevest string na cislo, pokud se to povede, vrati true, jinak false

if (povedloSePrevest == true) // if (povedloSePrevest) - ekvivalentni zapis
{
    Console.WriteLine("Zadano cislo " + cislo);
}
else
{
    Console.Write("Nezadano cislo. Nedokazu prevest " + vstupUzivatele + " na cele cislo.");
}
