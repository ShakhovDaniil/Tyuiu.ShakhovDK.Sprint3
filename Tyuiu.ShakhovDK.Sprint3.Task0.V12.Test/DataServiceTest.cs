using Tyuiu.ShakhovDK.Sprint3.Task0.V12.Lib;
namespace Tyuiu.ShakhovDK.Sprint3.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 13;
            int value = 1;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1.5;
            Assert.AreEqual(wait, res);
        }
    }
}