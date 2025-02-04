bool jeDobrePocasi = true;
bool jeVikend = true;

bool chciJitSportovat = jeDobrePocasi && jeVikend;
if (chciJitSportovat == true)
{
    Console.WriteLine("Jdu sportovat - je vikend a je hezky.");
}
else
{
    Console.WriteLine("Spotovat budu jindy, podminky nejsou vhodne.");
}

// toto je efektivne stejne - vykonase poku je pravda
if (chciJitSportovat) { }
if (chciJitSportovat == true) { }

// toto je efektivne stejne - vykona se pokud chciJitSportovat je nepravda (false)
if (chciJitSportovat == false) { }
if (!chciJitSportovat) { }


bool citimSeDobre = false;
// jeDobrePocasi => true
// !jeDobrePocasi => false
// !citimSeDobre => true
bool chciLenosit = !jeDobrePocasi || !citimSeDobre;
// bool chciLenosit = false || true;
if (chciLenosit)
{
    Console.WriteLine("Chci lenosit.");
}
else
{
    Console.WriteLine("Budu neco delat.");
}

if (!chciLenosit)
{
    Console.WriteLine("Budu neco delat - obraceny if");
}
else
{
    Console.WriteLine("Chci lenosit - obraceny if");
}
