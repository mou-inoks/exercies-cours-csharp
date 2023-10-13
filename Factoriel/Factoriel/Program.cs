
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


int fct1(int n)
{
    if(n == 1)
        return n * n;
    else
    {
        return n *= (n - 1);
    }
}

Console.WriteLine(fct1(5));

int fct2(int n)
{
    if( n == 1)
        return 1; 
    else
        return n *= fct2(n -1);
}

Console.WriteLine(fct2(5));