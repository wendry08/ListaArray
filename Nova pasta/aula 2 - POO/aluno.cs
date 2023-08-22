public class Aluno
{
    public string nome;
    public string email;
    public double nota1;
    public double nota2;

    public void CalcularMedia()
    {
        double media = (nota1 + nota2) / 2;
        Console.WriteLine($"A média é {media}");

        if(media <= 6)
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
            Console.WriteLine("Aprovado");
        }
        
    }
}