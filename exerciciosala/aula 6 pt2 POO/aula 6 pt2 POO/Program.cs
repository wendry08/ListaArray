public class Program
{
     static void Main(string[] args)
    {
        Pessoas p = new Pessoas("Elias", "065.789.322.67", "wendry.bed");
        Livros l = new Livros("vasco melhor que flamengo", "Elias", "2023", true,01);
        Emprestimo emprestimo = new Emprestimo();
        emprestimo.EmprestarLivro(p,l, new DateTime(2023, 08, 06));

        Pessoas p2 = new Pessoas("Maria", "065.789.322.67", "maria.silva");
        Livros l2 = new Livros("Java e melhor", "Elias","2023", false, 02); 
        emprestimo.DevLivro(l2, p2, new DateTime(2023, 03, 06)); 

       
    }
}