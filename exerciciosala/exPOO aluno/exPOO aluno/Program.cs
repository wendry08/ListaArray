class programa
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.nome = "Elias";
        aluno1.email = "email";
        Console.Write("Digite sua nota:");
        double primeiraNota = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite sua outra nota:");
        double segundaNota = Convert.ToDouble(Console.ReadLine());
        aluno1.CalcularMedia(primeiraNota, segundaNota);
    }
}
