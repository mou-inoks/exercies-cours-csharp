using System.Text;

var list = new List<string>() { "tache 1", "tache 2", "tache 5"};

list.ForEach(x => Console.WriteLine(x));

Console.WriteLine("________________________");

list.ForEach(x => x.Replace('2', '4'));
list.ForEach(x => Console.WriteLine(x));
