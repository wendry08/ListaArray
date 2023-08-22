public class Conta
{
    private double saldototal;

    public double GetSaldoTotal()
    {
        return saldototal;
    }
    public void SetSaldoTotal(double saldototal)
    {
        if(saldototal >= 0)
        {
            this.saldototal = saldototal;
        }
        else
        {
            Console.WriteLine("Valor invalido!");
        }
    }
    

}