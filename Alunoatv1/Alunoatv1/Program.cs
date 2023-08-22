List<Aluno> alunos = new List<Aluno>();
while (true)
{
    Console.WriteLine("quer cadastrar outro aluno");
    Console.WriteLine("0 - sim");
    Console.WriteLine("1 - não");
    Console.WriteLine("digite a acao escolhida");

    int opcaoescolhida = Convert.ToInt32(Console.ReadLine());
    if(opcaoescolhida == 1)
    {
        Aluno a = new Aluno();
        Console.Write("Digite o nome do aluno: ");
        a.nome = Console.ReadLine();

        Console.Write("Digite a matrícula do aluno: ");
        a.Matricula = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o CPF do aluno: ");
        a.CPF = Console.ReadLine();

        Console.Write("Digite a data de nascimento do aluno: ");
        a.dataNascimento = DateOnly.Parse(Console.ReadLine());// retira erros ao colocar a data de nascimento
        alunos.Add(a);
    }
    else if (opcaoescolhida == 0)
    {
        break;
    }
    else 
    {
        Console.WriteLine("opcao invalida");
    }
    Console.Clear();
    alunos.Sort();
    foreach (Aluno a in alunos)
    {
        Console.WriteLine($"O nome é: {a.nome} o cpf é:  {a.CPF}");
    }
}