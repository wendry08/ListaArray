/*int[] array = new int[2];
Console.WriteLine("digite a primeira nota: ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite a segunda nota");
array[1] = Convert.ToInt32(Console.ReadLine());

double media = (array[0] + array[1]) / 2;
Console.WriteLine($"a media é {media}");*/

List<string> Lista1 = new List<string>();
Lista1.Add("bergamasco");
Lista1.Add("wendry");
Lista1.Add("santos");

Console.WriteLine(Lista1[2]);



foreach (string str in Lista1)
{
    Console.WriteLine(str);
}