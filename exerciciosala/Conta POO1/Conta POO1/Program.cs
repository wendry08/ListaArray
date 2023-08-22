public class Programa
{
    static void Main(string[] args)
    {
        Conta conta = new Conta();
        conta.nomeCliete = "Elias";
        conta.tipoConta = "Corrente";
        conta.saldoTotal = 0;

        Console.Write("Informe o calor depositado: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        conta.Depositar(valor);
        Console.WriteLine($"O saldo após o deposito é {conta.saldoTotal}");
        Console.WriteLine("Informe o valor do saque: ");
        double saque = Convert.ToDouble(Console.ReadLine());
        conta.Sacar(saque);
        Console.WriteLine($"O saldo após o deposito é {conta.saldoTotal}");
    }
}