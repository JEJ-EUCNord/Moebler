using Moebler;

// Lav et nyt møbel
Moebel mitMoebel = new Moebel(120.50,"Træfabrikken");
Moebel mitAndetMoebel = new Moebel(33, "Poul");

// Lav et nyt TV
TV mitTV= new TV(3399,"LG",66);

// foretag testudskrivning
mitMoebel.Udskriv();
mitAndetMoebel.Udskriv();  
mitTV.Udskriv();
