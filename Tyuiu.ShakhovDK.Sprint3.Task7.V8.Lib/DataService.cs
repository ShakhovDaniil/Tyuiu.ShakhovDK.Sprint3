﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakhovDK.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 2)
                {
                    valueArray[index] = 0;
                }
                else
                {
                    y = Math.Round((Math.Sin(x) + ((Math.Cos(x) + 1.0) / (2 - x)) + 2.0 * x), 2);
                    valueArray[index] = y;
                }
                index++;
               
            }
            return valueArray;
        }
    }
}