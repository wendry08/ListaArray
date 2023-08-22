public class Program
{
    static void Main(string[] args)
    {
        Voo v = new Voo(01, DateTime.Now);
        while (true)
        {  
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1- Proxima cadeira livre");
            Console.WriteLine("2- Verificar");
            Console.WriteLine("3- Ocupar");
            Console.WriteLine("4- Vagas");

            int opçao = Convert.ToInt32(Console.ReadLine());

            switch (opçao)
            {
                case 1:
                    Console.WriteLine($"A primeira cadeira livre é {v.ProximoLivre()}");
                    break;

                case 2:
                    Console.WriteLine("Informe o numero de cadeira");
                    int ncadeira = Convert.ToInt32(Console.ReadLine());
                    v.Verificar(ncadeira);
                    break;

                case 3:
                    Console.WriteLine("Digite uma cadeira que deseja ocupar");
                    int nverificar = Convert.ToInt32(Console.ReadLine());
                    v.Ocupar(nverificar);
                    break;

                case 4:
                    Console.WriteLine($"A quantidade de cadeiras vagas é {v.Vagas()}");
                    break;

                default:
                    break;
                        

            }
        }
       

       
    }
}