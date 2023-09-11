//Calculatrice
Func<int, int, int> addition = (x, y) => x + y;
Func<int, int, int> soustraction = (x, y) => x - y;
Func<int, int, int> multiplication = (x, y) => x * y;
Func<int, int, int> division = (x, y) => y != 0 ? x/y : throw new DivideByZeroException("On divise pas par 0 imbecile");

int Calculatrice(Func<int,int,int> operation, int x, int y)
{
    return operation(x, y);
}
try
{
    Console.WriteLine(Calculatrice(division, 10, 0));
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}

//Somme d'une liste 
Func<Func<List<int>, int>> GenerateSumList = () =>
{
    return (liste) =>
    {
        return liste.Sum();
    };
};

Console.WriteLine(GenerateSumList()(new List<int>() { 1,2,3,4,5}));