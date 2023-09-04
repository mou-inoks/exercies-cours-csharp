List<string> taches = new List<string>();

void AjouterTache(string tache)
{
    taches.Add(tache);
}

AjouterTache("test1");
AjouterTache("test2");
AjouterTache("test3");
AjouterTache("test4");
AjouterTache("test5");

void AfficherTache(List<string> taches)
{
    taches.ForEach(x => Console.WriteLine(x));
}
Console.WriteLine("Taches avant");
AfficherTache(taches);

string Modifier(string l)
{
    l += " [Urgent]";
    return l;
}

void ModifierTaches(List<string> taches, Func<string, string> Modifier)
{
    for(int i = 0; i < taches.Count; i++)
    {
        taches[i] = Modifier(taches[i]);
    }
}
string Majusculs(string s)
{
    return s.ToUpper();
}

ModifierTaches(taches, Modifier);

Console.WriteLine("Taches après");

AfficherTache(taches);

Console.WriteLine("Taches après");

ModifierTaches(taches, Majusculs);

AfficherTache(taches);



