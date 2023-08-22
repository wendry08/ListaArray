public class Livros
{
    public string titulo;
    public string nomeAutor;
    public string anoLancamento;
    public bool status;
    public int codigoIdentificador;   
    
    public Livros(string titulo, string nomeAutor, string anoLancamento, bool status, int codigoIdentificador)
    {
        this.titulo = titulo;
        this.nomeAutor = nomeAutor;
        this.anoLancamento = anoLancamento;
        this.status = status;   
        this.codigoIdentificador = codigoIdentificador;
    }
}