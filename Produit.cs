public class Produit
{
    private string nom;
    private double prix;
	private TVA taux;
    public Produit(string nom,double prix,TVA taux)
    {
        this.nom = nom;
        this.prix = prix;
        this.taux= taux;
    }
    public override string ToString()
    {
        return this.nom;
    }
    public string getNom()
    {
        return this.nom;
    }

	public double getPrix()
    {
        return this.prix;
    }
    public TVA getTVA()
    {
        return this.taux;
    }
    public double getTTC()
    {
        return this.taux.getTTC(this.prix);
    }
}