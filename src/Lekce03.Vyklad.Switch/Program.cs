string cilovaStanice = "Praha-Kacerov";

/*
if (cilovaStanice == "Praha")
{
    Console.WriteLine("Jedeme do Prahy");
}
else if (cilovaStanice == "Praha")
{
    Console.WriteLine("Jedeme do Brna");
}
else
{
    Console.WriteLine("Tuto stanici neznam");
}
*/

switch (cilovaStanice)
{
    default:
        Console.WriteLine("Tuto stanici neznam");
        break;
    case "Praha":
    case "Praha-Bubenec":
    case "Praha-Zbraslav":
    case "Praha-Smichov":
    case "Praha-Dejvice":
    case "Praha-Hlavni nadrazi":
    case "Praha-Holesovice":
        Console.WriteLine("Jedeme do Prahy");
        break;
    case "Brno":
        Console.WriteLine("Jedeme do Brna");
        break;
}
