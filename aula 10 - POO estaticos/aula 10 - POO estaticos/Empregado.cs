
public class Empregado
{
    private string nome;
    private double aumentoSalario;
    private string salario;
    private DateTime dataAd;

    public Empregado(string nome, string salario, DateTime dataAd)
    {
        this.nome = nome;
        this.salario = salario;
        this.dataAd = dataAd;
        this.aumentoSalario = aumentoSalario;
        
    }
    public string Getnome()
    {
        return nome;
    }
    public string GetSalario()
    {
        return salario;
    }
    public string GetdataAd(DateTime dataAd)
    {
        return dataAd.ToString();
    }
    public string Setnome(string nome)
    {
        return this.nome = nome;
    }
    public string Setsalario(string salario)
    {
        return this.salario;
    }
    public DateTime SetdataAd(string dataAd)
    {
        return this.dataAd;
    }
    public aumenentoSalario(int x)
    {

    }

}