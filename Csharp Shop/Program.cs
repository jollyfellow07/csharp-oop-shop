// See https://aka.ms/new-console-template for more information
using Csharp_Shop;


Prodotto mela = new Prodotto("MELA", "questa mela è rossa",0.50, 5);
int codice = mela.GetCodice();
mela.articolo();
mela.stampa();

Prodotto telefono = new Prodotto("iphone", "Apple iPhone 13 è l’ultima uscita di casa Apple, apparentemente simile al suo predecessore, ma in realtà molto innovativo per display, batteria e fotocamera. ", 1000, 22);
int iphoneCodice = telefono.GetCodice();
telefono.articolo();
telefono.stampa();


Prodotto medicina = new Prodotto("tachipirina", "questa medicina serve per la febbre", 10.20, 10);
int medicinaCodice = medicina.GetCodice();
medicina.articolo();
medicina.stampa();



Console.ReadLine();