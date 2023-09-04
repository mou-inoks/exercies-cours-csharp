List<int> nombres = new List<int>() { 10,20,30,40,50};
Console.WriteLine("Après");

nombres.ForEach(n => Console.WriteLine(n));

List<int> l = new List<int>(nombres.OrderByDescending(x => x));
Console.WriteLine("Après");
l.ForEach(n => Console.WriteLine(n));

l.RemoveAll(x => x < 25);

Console.WriteLine("Remove");

l.ForEach(n => Console.WriteLine(n));



Console.WriteLine("Somme");

Console.WriteLine(l.Sum());
