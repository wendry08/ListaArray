public class Program
{
    static void Main(string[] args)
    {
        Conta conta = new Conta();
        conta.nomeCliente = "Wendry";
        conta.tipoConta = "corrente";
        conta.saldoTotal = 0;

        Console.WriteLine("informe o valor de deposito: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        conta.Depositar(valor);

        Console.WriteLine($"o saldo apos o deposito é {conta.saldoTotal}");
        Console.WriteLine("Informe o valor do saque: ");
        double saque = Convert.ToDouble(Console.ReadLine());
        conta.Sacar(saque);
        Console.WriteLine($"O saldo após o deposito é {conta.saldoTotal}");
    }
}
