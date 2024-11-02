using Tyuiu.ShakhovDK.Sprint3.Task7.V8.Lib;
DataService ds = new DataService();
int startValue = -5;
int stopValue = 5;
int len = ds.GetMassFunction(startValue, stopValue).Length;
double[] valueArray;
valueArray = new double[len];
valueArray = ds.GetMassFunction(startValue, stopValue);
Console.Title = "Спринт #3 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #3                                                                              *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                *");
Console.WriteLine("* Задание #7                                                                             *");
Console.WriteLine("* Вариант #8                                                                             *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
//Console.WriteLine("* УСЛОВИЕ:                                                                               *");
//Console.WriteLine("  Напишите программу, которая ищет среди целых чисел, \n" +
//    "принадлежащих числовому отрезку [11, 17] сумму всех делителей.");
//Console.WriteLine("******************************************************************************************");
//Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
//Console.WriteLine("******************************************************************************************");
//Console.WriteLine(" [-5, 5]");
//Console.WriteLine($" Старт шага = {startValue} ");
//Console.WriteLine($" Конец шага = {stopValue} ");
//Console.WriteLine("******************************************************************************************");
//Console.WriteLine("******************************************************************************************");
//Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine("+----------+----------+");
Console.WriteLine("|    X     |    f(x)  |");
Console.WriteLine("+----------+----------+");

for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("|{0,5:d}     | {1, 7:f2}  |", startValue, valueArray[i]);
    startValue++;
}
Console.WriteLine("+----------+----------+");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();