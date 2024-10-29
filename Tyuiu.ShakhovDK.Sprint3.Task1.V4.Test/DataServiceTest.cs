using Tyuiu.ShakhovDK.Sprint3.Task1.V4.Lib;
namespace Tyuiu.ShakhovDK.Sprint3.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 2;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 1.25;
            Assert.AreEqual(wait, res);
        }
    }
}