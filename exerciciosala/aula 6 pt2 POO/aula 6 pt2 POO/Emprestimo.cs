public class Emprestimo
{
    public Livros Livro;
    public Pessoas Pessoa;
    public DateTime dataEmprestimo;
    public DateTime dataDevolucao;

    public void EmprestarLivro(Livros livro, Pessoas pessoa, DateTime datadevolucao)
    {
        if(livro.status == true)
        {
            this.Livro = livro;
            this.Pessoa = pessoa;
            this.dataEmprestimo = DateTime.Now;
            this.dataDevolucao = datadevolucao;
            this.Livro.status = false;
            Console.WriteLine("Livro emprestado ");
        }
        else
        {
            Console.WriteLine("Livro indisponivel.");
        }
    }
    public void DevLivro(Livros livros, Pessoas pessoas, DateTime dataEmprestimo)
    {
       if (livros.status == false)
        {
            this.Livro = livros;
            this.Pessoa = pessoas;
            this.dataEmprestimo = DateTime.Now; 
            this.dataDevolucao= DateTime.Now;
            Console.WriteLine("Livro devolvido");
        }
       else
        {
            Console.WriteLine("Livro não devolvido");
        }
    }

   
}