using Tyuiu.ShakhovDK.Sprint3.Task0.V12.Lib;
DataService ds = new DataService();
int value, startValue, stopValue;
value = 1;
startValue = 1;
stopValue = 13;
double res;
Console.Title = "Спринт #3 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #3                                                                              *");
Console.WriteLine("* Тема: Оператор цикла for                                                               *");
Console.WriteLine("* Задание #0                                                                             *");
Console.WriteLine("* Вариант #12                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("* Написать программу используя цикл for,\n " +
"которая вычисляет произведение ряда по формуле, при t = 1.\n" +
"    13   k\n" +
"p = П  (t  + (1 / k + 1))\n" +
"  k = 1");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine($"* t = {value}                                                                           *");
Console.WriteLine($"* k_0 = {startValue}                                                                    *");
Console.WriteLine($"* k_k = {stopValue}                                                                     *");
res = ds.GetMultiplySeries(value, startValue, stopValue);
Console.WriteLine("******************************************************************************************");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine($"p = {res}");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();