﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakhovDK.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            int i;
            double p = 1.5;
            for (i = (startValue + 1); i <= stopValue; i++)
            {
                p *= Math.Pow(value, i) + (1 / (i + 1));
            }
            return Math.Round(p, 3);
        }
    }
}
