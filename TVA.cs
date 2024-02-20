
public class TVA
{
    private double taux;
    public TVA(double taux2)
    {
        this.taux = taux2;
    }
    public void setTaux(double taux3)
    {
        this.taux = taux3;
    }
    public double getTaux()
    {
        return this.taux;
    }
     public double getTTC(double prix)
    {
        double ttc = prix*(1+(0.01*this.taux));
        Console.WriteLine(ttc);
        return ttc;
    }

}