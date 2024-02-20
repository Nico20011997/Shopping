using System;
class Principale
{
static void Main(string[] args)
{
        TVA taux;
        taux= new TVA(5);
        TVA taux2;
        taux2= new TVA(20);
        TVA taux3;
        taux3= new TVA(15);

		Produit	Carotte;
		Carotte= new Produit("Carotte",5,taux);

        Produit	Voiture;
		Voiture= new Produit("Lamborghini",15,taux3);

        Produit	iPad;
		iPad= new Produit("iPad",5,taux2);

        Chariot prod;
        prod = new Chariot();


        prod.ajoutProd(Carotte);
        prod.ajoutProd(Voiture);
        prod.ajoutProd(iPad);
        Console.WriteLine(prod.total());
}
}
