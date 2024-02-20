public class Chariot 
{
    private Produit[] prod ;
    public Chariot()
    {
        this.prod=new Produit[50];
    }
    
      public void ajoutProd(Produit prod)
    {
        for (int i=0;i<this.prod.Length;i++)
        {
            if (this.prod[i] != null)
            {
                continue;
            }
            else
            {
                this.prod[i] = prod;
                break;
            }
        }
    }
    public double total()
    {
        double res=0;
        foreach(Produit p in this.prod)
        {
            if (p != null)
            {
                res = res + p.getTTC();
                Console.WriteLine("Total");
            }
        }
        return res;
    }
}
