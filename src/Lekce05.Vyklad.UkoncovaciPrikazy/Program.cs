// Ukoncovaci Prikazy - RETURN, BREAK, CONTINUE
Console.WriteLine("Začátek programu.");
while (true)
{
    Console.WriteLine("Začátek nekonečného cyklu, první část... Vykoná se vždy.");

    Console.WriteLine("Chceš ukončit program? A/N");
    string vstupUzivatele = Console.ReadLine();
    if (vstupUzivatele == "A")
    {
        Console.WriteLine("Končím program.");
        return; // ukoncime program
    }

    Console.WriteLine("Chceš vyskočit z aktuálního cyklu? A/N");
    vstupUzivatele = Console.ReadLine();
    if (vstupUzivatele == "A")
    {
        Console.WriteLine("Vyskakuju z aktuálního cyklu.");
        break; // vyskocime z aktualniho cyklu
    }

    Console.WriteLine("Chceš přeskočit následující část program a vrátit se na začátek cyklu? A/N");
    vstupUzivatele = Console.ReadLine();
    if (vstupUzivatele == "A")
    {
        Console.WriteLine("Vracím se na začátek cyklu.");
        continue; // preskoci zbytek cyklu a vraci se na jeho zacatek
    }

    Console.WriteLine("Toto je druhá část programu...");
}

Console.WriteLine("Konec programu.");
