public class Program
{
    static void Main(string[] args)
    {
        Gabarito gabi = new Gabarito();

        Prova p = new Prova(gabi);

        Console.WriteLine("informe o nome do aluno!");
        string nome = Console.ReadLine();

        for(int i = 0; i < p.respostaAluno.Length; i++)//quantidade de resposta que vai passar
        {
            Console.WriteLine($"Informe a resposta da questão {i+1}");
            char resposta = Convert.ToChar(Console.ReadLine());
            p.RespostaAluno(char.ToUpper(resposta));
        }
        Console.WriteLine($"A quantidade de acertos é {p.Acertos()}");
        Console.WriteLine($"A nota é {p.Nota()}");

        p.Nota();
    }
}
