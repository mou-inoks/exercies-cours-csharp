List<int> nombres = new List<int> { 10, 20, 30, 40, 50 };

// Utilisation d'une fonction anonyme pour trier la liste de nombres dans l'ordre décroissant
nombres.Sort((x, y) => y.CompareTo(x));

// Utilisation d'une fonction anonyme pour filtrer les nombres supérieurs à 25
List<int> nombresFiltres = nombres.Where(num => num > 25).ToList();

// Utilisation d'une fonction anonyme pour calculer la somme des nombres dans la liste filtrée
int somme = nombresFiltres.Aggregate((acc, num) => acc + num);
Console.WriteLine("Liste triée en ordre décroissant:");

foreach (var num in nombres)
{
 Console.Write(num + " ");
}
Console.WriteLine("\nNombres supérieurs à 25:");
foreach (var num in nombresFiltres)
{
 Console.Write(num + " ");
}
Console.WriteLine("\nSomme des nombres filtrés: " + somme);

