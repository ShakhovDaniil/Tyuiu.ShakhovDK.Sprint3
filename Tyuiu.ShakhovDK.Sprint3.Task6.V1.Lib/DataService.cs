using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShakhovDK.Sprint3.Task6.V1.Lib
{
    public class DataService : ISprint3Task6V1
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res_sum = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        res_sum += d;
                    }
                }
            }
            return res_sum;
        }
    }
}
