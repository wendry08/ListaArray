public class Program
{
    static void Main(string[] args)
    {
        Juro juros = new Juro();

        Console.WriteLine("Digite um valor: ");
        double valor = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a taxa de juros");
        double taxadejuros = Convert.ToDouble(Console.ReadLine());


        double Juros = juros.CalcularJuros(valor,taxadejuros);
        double total = Juros + valor;
        Console.WriteLine($"o juros calculados é {Juros} e a taxa de juro é {valor + Juros}");


    }
}