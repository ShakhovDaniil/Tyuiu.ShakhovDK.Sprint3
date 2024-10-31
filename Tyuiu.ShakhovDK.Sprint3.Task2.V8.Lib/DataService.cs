using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakhovDK.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            do
            {
                p *= (1.0 / Math.Pow(Math.Cos(5) + 1.0, 2));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(p, 3);
        }
    }
}
