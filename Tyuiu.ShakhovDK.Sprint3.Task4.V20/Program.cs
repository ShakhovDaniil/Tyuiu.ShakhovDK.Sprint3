using Tyuiu.ShakhovDK.Sprint3.Task4.V20.Lib;
DataService ds = new DataService();
int startValue = -5, stopValue = 5;
double res;
Console.Title = "Спринт #3 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #3                                                                              *");
Console.WriteLine("* Тема: Использование операторов continue и break в циклах                               *");
Console.WriteLine("* Задание #4                                                                             *");
Console.WriteLine("* Вариант #20                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("На отрезке, где x принимает значения от -5 до 5,\n " +
    "вычислить значение функции y=x/(cos(x) - x)+2,5\n" +
    "При х = 0 пропустить значение. Полученные значения перемножать");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine($" Старт шага = {startValue}");
Console.WriteLine($" Конец шага = {stopValue}");
res = ds.Calculate(startValue, stopValue);
Console.WriteLine("******************************************************************************************");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine($"y = {res}");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();