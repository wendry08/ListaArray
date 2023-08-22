public class Prova
{
    //utilizado para armazenar as resposta do aluno
    public char[] respostaAluno = new char[5];

    //Criar um objeto do tipo Gabarito
    Gabarito gaba;

    /*
     * criar o metodo construtor da classe prova
     * esse metodo recebe um parametro do tipo Gabarito
     
    */
    public Prova(Gabarito gaba)
    {
        this.gaba = gaba;
    }

    public void RespostaAluno(char resposta)
    {
        for(int i = 0; i < respostaAluno.Length; i++)
        {
            if (respostaAluno[i] == 0)
            {
                respostaAluno[i] = resposta;
                break;
            }
        }
    }
    

    public int Acertos()
    {
        int qtdAcertos = 0; 

        for(int i = 0; i < respostaAluno.Length;i++)
        {
            if (respostaAluno[i] == gaba.RespostaQuestao(i))
            {
                qtdAcertos += 1;
            }
        }
        return qtdAcertos;
    }
    public double Nota()
    {
        double nota = 0;

        for(int i = 0; i < respostaAluno.Length;i++)
        {
            if (respostaAluno[i] == gaba.RespostaQuestao(i))
            {
                if( i < 10)
                {
                    nota += 0.5;

                }
                else
                {
                    nota += 1;
                }


            }
        }

        return nota;
    }
    static void Maior()
    {

    }
}
