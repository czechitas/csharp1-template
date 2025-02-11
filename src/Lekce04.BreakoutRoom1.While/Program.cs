/*
// Vytvorte cyklus, ktery se uzivatele bude ptat na jeho rok narozeni
// tak dlouho, dokud uzivatel nezada spravne rok narozeni
// kdyz zada spravne cislo, vypocitejte a vypiste jeho vek
*/

Console.WriteLine("Zadej rok narození: ");
string vstupUzivateleText = Console.ReadLine();
int rokNarozeniUzivatele;
bool povedloSePrevest = int.TryParse(vstupUzivateleText, out rokNarozeniUzivatele);

while (!povedloSePrevest) // DOKUD se nepovedlo prevest, povedloSePrevest == false
{
    // donut uzivatele zadat vek znovu.
    Console.WriteLine("Nespravne zadané číslo. Zadej rok narození: ");
    vstupUzivateleText = Console.ReadLine();
    povedloSePrevest = int.TryParse(vstupUzivateleText, out rokNarozeniUzivatele);
}

int vekUzivatele = 2025 - rokNarozeniUzivatele;
Console.WriteLine($"Je ti {vekUzivatele} let.");
