﻿using Tyuiu.ShakhovDK.Sprint3.Task2.V8.Lib;
DataService ds = new DataService();
int startValue, stopValue;
startValue = 1;
stopValue = 15;
double res;
Console.Title = "Спринт #3 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #3                                                                              *");
Console.WriteLine("* Тема: Оператор цикла do-while                                                          *");
Console.WriteLine("* Задание #2                                                                             *");
Console.WriteLine("* Вариант #8                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Написать программу используя цикл do...while, " +
    "которая вычисляет произведение ряда по формуле");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine($"* k_0 = {startValue}                                                                    *");
Console.WriteLine($"* k_k = {stopValue}                                                                     *");
res = ds.GetMultiplySeries(startValue, stopValue);
Console.WriteLine("******************************************************************************************");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine($"p = {res}");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();