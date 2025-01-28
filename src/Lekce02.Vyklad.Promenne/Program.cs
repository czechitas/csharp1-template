// Napíše do konzole to, co je mezi kulatými závorkami.
Console.WriteLine("Hello, Lekce02!");

/*
Toto je komentář na více řádků
i tento řádek je zakomentován
*/

// Proměnné
int celeCislo = 5; // deklaroval a inicializoval s hodnotou celociselnou promennou
int zalohaPrvnihoCisla = celeCislo;
celeCislo = 10; // prepis hodnoty promenne

// Vypis do konzole
int vypisCelehoCisla = 7;
Console.WriteLine(vypisCelehoCisla);
Console.WriteLine("Menim hodnotu promenne.");
vypisCelehoCisla = 13;
Console.WriteLine(vypisCelehoCisla);

int celociselneDeleni = 5 / 3;
Console.WriteLine(celociselneDeleni); // vysledkem 5/3 bude 1

// Desetinna cisla
double desetinneCislo = 3.14;
Console.WriteLine(desetinneCislo);
double soucet = desetinneCislo + 0.86;
Console.WriteLine(soucet);

//stringy
string text1 = "Ahoj";
string text2 = "Czechitas!";
string sectenyText = text1 + " " + text2;
Console.WriteLine(sectenyText);

// Nacteni vstupu od uzivatele
Console.WriteLine("Uzivateli, zadej sve jmeno:");
string vstupUzivatele = Console.ReadLine();
Console.WriteLine("Uzivateli, tve jmeno je: " + vstupUzivatele);
