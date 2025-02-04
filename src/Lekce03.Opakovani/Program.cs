// See https://aka.ms/new-console-template for more information

int hadaneCislo = 4;

Console.WriteLine("Zadej cislo od 0 do 10");
string textovyTip = Console.ReadLine();

int tip = int.Parse(textovyTip);

bool cislaSeRovnaji = tip == hadaneCislo;
if (cislaSeRovnaji)
{
    Console.WriteLine("Hura! Uhadl/a jsi!");
}
else if (tip > hadaneCislo)
{
    Console.WriteLine("Mimo! Tip je moc vysoky");
}
else if (tip < hadaneCislo)
{
    Console.WriteLine("Mimo! Tip je moc nizky");
}

