// Výběr nápoje:

// Vytvoř celočíselnou proměnnou cisloNapoje typu int.
// Vypiš do konzole nabídku nápojů:
// 1 - Káva
// 2 - Čaj
// 3 - Limonáda
// 4 - Voda
// Požádej uživatele, aby zadal číslo nápoje a hodnotu ulož do proměnné cisloNapoje.

// Použití switch:
// Použij příkaz switch na proměnnou cisloNapoje.
// Pro každou možnost (1 - 4) vypiš do konzole odpovídající zprávu (např. "Vybrali jste kávu").
// Přidej default pro případ nápoje, který není v menu - bude vypisovat "Neznámý výběr nápoje".

// Rozsireni:
// Přidej proměnnou mnozstvi typu int pro množství nápoje.
// Po výběru nápoje požádej uživatele, aby zadal množství.
// Vypiš do konzole celkovou zprávu, například "Vybrali jste 2 kávy".

// BONUS: pouzij interpolovany string

int cisloNapoje;

Console.WriteLine("1 - Káva");
Console.WriteLine("2 - Čaj");
Console.WriteLine("3 - Limonáda");
Console.WriteLine("4 - Voda");

Console.WriteLine("Zadej cislo napoje:");
cisloNapoje = int.Parse(Console.ReadLine());

Console.WriteLine("Zadej mnozstvi:");
int mnozstvi = int.Parse(Console.ReadLine());

switch (cisloNapoje)
{
    case 1:
        Console.WriteLine("Vybral jsi " + mnozstvi + " kávu/káv!");
        break;
    case 2:
        Console.WriteLine("Vybral jsi " + mnozstvi + "čaj/čaje!");
        break;
    case 3:
        Console.WriteLine("Vybral jsi " + mnozstvi + "limonádu/limonády!");
        break;
    case 4:
        Console.WriteLine("Vybral jsi " + mnozstvi + "vodu/vody!");
        break;
    default:
        Console.WriteLine("Neznámý výběr nápoje");
        break;
}
