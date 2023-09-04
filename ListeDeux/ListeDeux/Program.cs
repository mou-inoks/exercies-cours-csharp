var list = new List<int>() { 85,92,78,95,88,70,89};

list.ForEach(x => Console.WriteLine(x));

Console.Write("Moyenne ",list.Sum() / list.Count);

Console.WriteLine("Minimum",list.Min());
Console.WriteLine("Maximum",list.Max());

list.Remove(list.Min());

list.Add(93);
Console.WriteLine("------------------");
list.Sort();

list.ForEach(x => Console.WriteLine(x));