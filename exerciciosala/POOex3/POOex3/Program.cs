public class Programa
{
    public static void Main(string[] args)
    {
        Hora tempo = new Hora();

        double HoraMin = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(HoraMin * 60);

        double MinSeg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(MinSeg / 60);


        double SegMin = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(SegMin / 3600);




    }


}