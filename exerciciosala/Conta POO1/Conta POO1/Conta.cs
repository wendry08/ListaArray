public class Conta
{
    public string nomeCliete;
    public string tipoConta;
    public double saldoTotal;

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldoTotal += valor;
        }
        else
        {
            Console.WriteLine("Valor invalidado");
        }

    }
    public void Sacar(double valor)
    {
        if (valor <= saldoTotal)
        {
            saldoTotal -= valor;
        }
        else
        {
            Console.WriteLine("Valor invalido");
        }

    }

}