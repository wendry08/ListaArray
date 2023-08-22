int[] array = new int[2];
Console.WriteLine("digite a primeira nota: ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite a segunda nota");
array[1] = Convert.ToInt32(Console.ReadLine());

double media = (array[0] + array[1]) / 2;
Console.WriteLine($"a media é {media}");

List<string> Lista1 = new List<string>();
Lista1.Add("bergamasco");//adiciona elemento no final da lista
Lista1.Add("wendry");
Lista1.Add("santos");
Lista1.Insert(0, "luquinha"); // insere um elemento em uma posição

Lista1.Remove("wendry");//remove o elemento
Lista1.RemoveAt(1);// remove por posicao

Console.WriteLine(Lista1[1]);//apresenta a 1 posicao
Console.WriteLine(Lista1.Count);//apresenta o tamanho da lista



foreach (string s in Lista1)
{
    Console.WriteLine(s);
}