int CalculerSomme(int n)
{
    if (n < 10)
        return n;
    else
        return n % 10 + CalculerSomme(n / 10);
}

Console.WriteLine(CalculerSomme(55));