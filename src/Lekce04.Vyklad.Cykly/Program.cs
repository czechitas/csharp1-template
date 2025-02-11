// bool jeVMisceChips = true;
// if (jeVMisceChips) //ekvivalentni zapis je jeVMisceChips == true
// {
//     Console.WriteLine("Jim chips, mnam.");
// }
// jeVMisceChips = true;
// jeVMisceChips = false;

// jeVMisceChips = true;
// while (jeVMisceChips) // DOKUD je v misce chips, zde se program zacyklí
// {
//     Console.WriteLine("Jim chips, mnam.");
// }

/*
int pocetChipsuVMisce = 3;
int pocetSnezenychChipsu = 0;
while (pocetChipsuVMisce > 0)
{
    Console.WriteLine("Jim chips, mnam.");
    //pocetSnezenychChipsu = pocetSnezenychChipsu + 1;
    pocetSnezenychChipsu++; //ekvivalentni zapis
    Console.WriteLine("Snedl jsem uz " + pocetSnezenychChipsu + " chipsu");
    Console.WriteLine($"Snedl jsem uz {pocetSnezenychChipsu} chipsu");
    //pocetChipsuVMisce = pocetChipsuVMisce - 1;
    pocetChipsuVMisce--; //ekvivalentni zapis
}
*/

int cislo = 1;
while (cislo <= 4)
{
    Console.WriteLine("Ahoj.");
    cislo++; //1,2,3,4
}

string vstupUzivateleText = Console.ReadLine();
int vekUzivatele;
bool povedloSePrevest = int.TryParse(vstupUzivateleText, out vekUzivatele);

while(/*nepovedloSePrevest*/)
{
 // donut uzivatele zadat vek znovu.
}
