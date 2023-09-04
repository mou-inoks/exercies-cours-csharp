
//Recursive
static ulong CalculerFactorielle(ulong n)
{
    if (n < 0)
        throw new ArgumentException("La factorielle n'est définie que pour les nombres positifs.");
    else if (n == 0)
        return 1;
    else
    {
        ulong resultat = 1;
        for (ulong i = 1; i <= n; i++)
        {
            resultat *= i;
        }
        return resultat;
    }
}

ulong n = 50;
ulong resultat = CalculerFactorielle(n);
Console.WriteLine($"La factorielle de {n} est {resultat}");

ulong Recursive(ulong n)
{
    if (n == 1)
        return 1;
    else
    {
        return n* Recursive(n - 1);
    }
}

Console.WriteLine(Recursive(30));


