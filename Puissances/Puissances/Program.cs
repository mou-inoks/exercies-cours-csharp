using System.Diagnostics;

Stopwatch timePerParse;

Func<double, double, double> CalculerPuissanceIterative = (bases, exposant) => Math.Pow(bases, exposant);


double CalculerPuissanceIterativeNrml(double bases, double exposant)
{
    double result = 1;
    for(int i = 1; i <= exposant; i++)
    {
        result *= bases;
    }
    return result;
}
timePerParse = Stopwatch.StartNew();
Console.WriteLine(CalculerPuissanceIterativeNrml(2, 50));
timePerParse.Stop();
Console.WriteLine("Nb ticks : " + timePerParse.ElapsedTicks);
timePerParse = Stopwatch.StartNew();
Console.WriteLine(CalculerPuissanceIterative(2,50));
timePerParse.Stop();
Console.WriteLine("Nb ticks : " + timePerParse.ElapsedTicks);
double CalculerPuissanceRecursive(double x, double n)
{
    if (n == 0)
        return 1;
    else
        return x *= CalculerPuissanceRecursive(x, n-1);
}
timePerParse = Stopwatch.StartNew();
Console.WriteLine(CalculerPuissanceRecursive(2, 50));
timePerParse.Stop();
Console.WriteLine("Nb ticks : " + timePerParse.ElapsedTicks);