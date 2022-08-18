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
mitMoebel.Udskriv();
mitTV.Udskriv();
