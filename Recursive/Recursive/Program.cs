//Non recursive
int fct1(int n)
{
    int multiplication = 1;
    for (int i = 1; i <= n; i++)
    {
        multiplication *= i;
    }
    return multiplication;
}
Console.WriteLine(fct1(5)); // 120


// 1. Recursive mode 
int fct2(int n)
{
    if (n == 1)
        return 1;
    else
    {
        return n * fct2(n - 1);
    }
}
Console.WriteLine(fct2(5));


