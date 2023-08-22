public class Conta
{
    public string nomeCliente;
    public string tipoConta;
    public double saldoTotal;

    public void Depositar(double valor)
    {
        Console.WriteLine("Informe um valor");
        if(valor > 0)
        {
            saldoTotal += valor;
        }
        else
        {
            Console.WriteLine("Valor invalido");
        }
    }
        
    public void Sacar(double valor)
    {
        if(valor <= saldoTotal)
        {
            saldoTotal -= valor;
        }
        else
        {
            Console.WriteLine("O valor é invalido ");
        }

    }
    
    
        
    


     
   
    
        
    
   
    

}