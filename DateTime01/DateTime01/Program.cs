
//Console.WriteLine("Informe a data de nascimento");
//DateTime datanasc = Convert.ToDateTime(Console.ReadLine);
//Console.WriteLine(datanasc.DayOfWeek); 

DateTime d1 = new DateTime(2023, 07, 24);
DateTime d2 = new DateTime(2023, 07, 24);

//o - datas iguais
//-1 - a primeira data é anterior a seguda
//1 - a primeira data é posterior a segunda
int retornoCompararDatas = DateTime.Compare(d1, d2);
//Console.WriteLine(retornoCompararDatas);
Console.WriteLine(DateTime.Compare(d1,d2));

DateTime d5 = DateTime.Parse("07/04/2023");
DateTime d6 = DateTime.Parse("07-04-2023");
Console.WriteLine(d5);
Console.WriteLine(d6);

DateOnly dto = DateOnly.Parse("07-04-2023");
Console.WriteLine(dto);

//DateTime d3 = d1.AddDays(10);//adiciona dias 
//Console.WriteLine(d3);
//DateTime d4 = d2.AddYears(3);

//TimeSpan a = d1.Subtract(d2);
//Console.WriteLine(a.Days);

//TimeSpan b = new TimeSpan(6290, 00, 00);
//DateTime novadata = DateTime.Now.Subtract(b);
//Console.WriteLine(novadata);

//Console.WriteLine(d1);//data
//Console.WriteLine(d2);//horario

//Console.WriteLine(DateTime.Now);//horario atual
//Console.WriteLine(DateTime.UtcNow);//horario globalizado
//Console.WriteLine(DateTime.Today);//só a data
//Console.WriteLine(d1.Year);//só o ano
//Console.WriteLine(d1.Month);//só o mes
//Console.WriteLine(d1.DayOfYear);//dia da semana


