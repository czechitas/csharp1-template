/*
Trenink na FOR cykly

Vytvořte cyklus, ktery vypise poporade vsechna cisla od 0 do 20
Modifikujte cyklus tak, aby vypsal pouze suda cisla (vyuzij k vyberu pouze sudych cisel iteracni promennou),
použij operátor modulo (zbytek po dělení) i % 2 == 0

bool jeCisloDelitelneDvemiBezeZbytku = (i % 2 == 0);

Volitelne si od uzivatele vyzadejte pocatecni a koncova cisla, aby mohl vypsat napr. vsechna suda cisla od 100 od 200
BONUS: Ptejte se uzivatele na cislo do te doby, dokud ho nezada spravne :-) (TryParse)
*/

int pocetecniCislo = 50;
int koncoveCislo = 70;

int zbytekPoDeleniTremi = 7 % 3;
Console.WriteLine("Zbytek po deleni tremi je: " + zbytekPoDeleniTremi);

for (/*iteracni promenna*/ int i = pocetecniCislo; /*podminka, pokud je splnena, cyklus se provadi dale*/ i <= koncoveCislo; /*kod vykonany po kazdem cyklu*/ i++)
{
    bool jeSude = i % 2 == 0;
    bool jeLiche = i % 2 != 0;
    bool jeDelitelnePeti = i % 5 == 0;
    if (jeSude)
    {
        Console.WriteLine(i);
    }
}

