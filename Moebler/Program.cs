using Moebler;

// Lav et nyt møbel
Moebel mitMoebel = new Moebel();
mitMoebel.Pris = 120.50;
mitMoebel.Fabrikant = "Træfabrikken";

// Lav et nyt TV
TV mitTV= new TV();
mitTV.Pris = 3399;
mitTV.Fabrikant = "LG";
mitTV.Stoerrelse = 66;

// foretag testudskrivning
Console.WriteLine(mitMoebel.Fabrikant);
Console.WriteLine(mitMoebel.Pris);
Console.WriteLine();
Console.WriteLine(mitTV.Fabrikant);
Console.WriteLine(mitTV.Stoerrelse);
Console.WriteLine(mitTV.Pris);  
