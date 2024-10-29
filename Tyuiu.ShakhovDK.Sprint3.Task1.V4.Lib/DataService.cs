using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakhovDK.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            int i;
            double s = 0;
            while ((i = startValue) <= stopValue)
            {
                s += Math.Pow(1.0 / startValue, 2);
                startValue++;
            }
            return Math.Round(s, 3);
        }
    }
}
