public class Program
{
    public void Main(string[] args)
    {
        Parametro resultado = new Parametro();

        double retornarSoma = resultado.Somar(10, 99);
        Console.WriteLine(retornarSoma);

        resultado.Subtrair(30, 27);
        double retornarSubtracao = resultado.Subtrair(54, 12);
        Console.WriteLine(retornarSubtracao);

        resultado.Multiplicar(15, 87);
        double retornoMultiplicacao = resultado.Multiplicar(10, 5);
        Console.WriteLine(retornoMultiplicacao);

        resultado.Dividir(81, 9);
        double retornoDividir = resultado.Dividir(81, 9);
        Console.WriteLine(retornoDividir);
    }
}