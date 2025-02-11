// Cyklus FOR

// Cyklus se opakuje urcit pocetkrat

// int i=0; promenna i, typicky zacina na 0
// i < 3; podminka - DOKUD je splnena, opakuj cyklus
// i++ - co se ma stat po kazdem opakovani, zde zvysujeme i o 1
for (int i = 0; i < 3; i = i + 2) // i += 2
{
    Console.WriteLine(i);
}

int pocetChipsuVMisce = 3;
for (int cisloChipsu = 1; cisloChipsu <= pocetChipsuVMisce; cisloChipsu++)
{
    Console.WriteLine("Jim chips cislo " + cisloChipsu);
}

for (int cisloChipsu = 0; cisloChipsu < pocetChipsuVMisce; cisloChipsu++)
{
    Console.WriteLine("Jim chips cislo " + (cisloChipsu + 1));
}

// for (int i = 0; i < length; i++)
// {

// }
