// Hodnotove a Referencni typy

// Hodnotove typy (bool, char, int, double, ...)
var a = 10; //📦
var b = a; //📦, vytváří se kopie hodnoty proměnné "a"

a = 20;

Console.WriteLine($"a={a}, b={b}");

// Referencni typy (class, int[], List<int>, string, ....)
Clovek marie = new Clovek("Marie", "Novotna"); //📦
var takyMarie = marie; //➡️ ukazatel, nevytvarime kopii, potenciálně hodně drahé
// "takyMarie" se kouká na stejné místo jako "marie"

marie.Prijmeni = "Krusna"; //změníme hodnotu všem proměnným, které se koukají v paměti na toto místo

marie.PredstavSe();
takyMarie.PredstavSe();

int[] pole = [1, 2, 3];
int[] druhePole = pole;
druhePole[0] = 99; // Změní hodnotu v obou polích, obě pole se koukají na stejné hodnoty
Console.WriteLine(pole[0]); // Výstup: 99

// IMMUTABLE string
var jmeno = "Adam"; //📦 (speciální druh IMMUTABLE - po vytvoření již nelze změnit, každá hodnota řetězce je vlastní 📦)
jmeno += "son"; //vytvoří se nová 📦 "Adamson" + ➡️ ukazatel se změní na tuto novou 📦
var druheJmeno = jmeno; //vytvoříme ➡️ ukazatel, který se kouká do paměti tam, kde se kouká "jmeno"
jmeno = "Damianson"; //vytvoří se nová 📦 "Damianson" + ➡️ ukazatel se změní na tuto novou 📦

Console.WriteLine($"jmeno={jmeno}, druheJmeno={druheJmeno}");

public class Clovek
{
    public string Jmeno;
    public string Prijmeni;

    public Clovek(string jmeno, string prijmeni)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
    }

    public void PredstavSe()
    {
        Console.WriteLine($"{Jmeno} {Prijmeni}");
    }
}
















