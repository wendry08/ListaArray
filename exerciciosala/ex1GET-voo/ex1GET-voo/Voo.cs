public class Voo
{
    private DateTime dataVoo;
    private int numVoo;
    public bool[] cadeiras = new bool[100];

    public Voo(int numVoo,DateTime dataVoo)
    {
        this.numVoo = numVoo;
        this.dataVoo = dataVoo;
    }
    public int ProximoLivre()
    {
        for (int i = 0; i < cadeiras.Length; i++)
        {
            if (cadeiras[i] == false)
            {
                return i;
                break;
            }
                     
        }
        Console.WriteLine("");
        return -1;
    }
    public bool Ocupar(int numCadeira)
    {
        if (cadeiras[numCadeira] == false)
        {
            this.cadeiras[numCadeira] = true;
            Console.WriteLine("A cadeira foi ocupada");
            return true;
        }
        else
        {
            Console.WriteLine("Cadeira já está ocupada!");
            return false;
        }
    }
    public bool Verificar(int numCadeira)
    {
        if (cadeiras[numCadeira])
        {
            
            Console.WriteLine("a cadeira está ocupada");
            return true;
        }
        else
        {
            Console.WriteLine("A cadeira está livre");
            return false;
        }
    }
    public int Vagas()
    {
        int cont = 0;
        for(int i = 0; i < cadeiras.Length;i++)
        {
            if(cadeiras[i] == false)
            {
                cont += 1;
            }

        }
        return cont;
    }
    public double GetVoo()
    {
        return this.numVoo;
    }
    public DateTime GetDataVoo()
    {
        return this.dataVoo;
    }
    public void SetVoo(int numVoo)
    {
        this.numVoo = numVoo;
    }
    public void SetDataVoo(DateTime dataVoo)
    {
        this.dataVoo = dataVoo;
    }
}