using System;

class Cacharro
{
    static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro();
        cachorro.nome = "magli";
        cachorro.raca = "pastor alemao";

        string B = "RUFF RUFF";
        cachorro.Latir(B);

        Cachorro cachorro2 = new Cachorro();
        cachorro2.nome = "brasil";
        cachorro2.raca = "bulldog";

        string A = "Auau";
        cachorro2.Latir(A);

    }
}