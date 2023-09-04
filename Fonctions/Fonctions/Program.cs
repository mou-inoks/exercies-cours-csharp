Func<int, int, int> anonym = (int nb1, int nb2) => nb1 + nb2;


Func<int,int, bool> isGreatherThan = (int nb1, int nb2) => nb1 > nb2 ? true: false;

Action<int> showNumber = (int number) => Console.WriteLine(number);

Func<int, List<int>, int> returnNumber = (int n, List<int> l) => (int)Math.Pow(l[n], 2);

Func<List<int>, List<int>> onlyPairNumbers = (List<int> list) => list.Where(x => x % 2 == 0).ToList();

bool TestValeurs(Func<int, int, bool> test, int nb1, int nb2)
{
    return test(nb1, nb2);
}


Console.WriteLine(TestValeurs(isGreatherThan, 1,4));