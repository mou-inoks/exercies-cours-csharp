var voitures = new List<Voiture>()
{
 new Voiture("Hennessey", "Venom GT", 1244),
 new Voiture("Bugatti", "Centodieci", 1600),
 new Voiture("Zenovo", "ST1", 1104),
 new Voiture("GTA", "Spano", 1244),
 new Voiture("Ferrari", "LaFerrari", 963),
 new Voiture("Aston Martin", "Valkyrie",1176),
 new Voiture("Bristol", "T Fighter",1012),
 new Voiture("SSC", "Tuatara",1750),
 new Voiture("McLaren", "Speedtail",1070),
 new Voiture("Koenigsegg", "Regera",1500),
};
//Afficher la liste normalement 

voitures.ForEach(x => Console.WriteLine(x.ToString()));

//Order la liste par puissance 

// voitures.OrderBy(x => x.Puissance).ToList().ForEach(x => Console.WriteLine($"Marque: {x.Marque} - Model: {x.Model} - Puissance: {x.Puissance}"));



class Voiture
{
 public string Marque { get; set; }
 public string Model { get; set; }
 public int Puissance { get; set; }

 public Voiture(string marque, string model, int puissance)
 {
  this.Marque = marque;
  this.Model = model;
  this.Puissance = puissance;
 }
 public override string ToString()
 {
  return $"Marque: {Marque} - Model: {Model} - Puissance: {Puissance}";
 }
}