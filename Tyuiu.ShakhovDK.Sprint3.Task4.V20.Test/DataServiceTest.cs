using Tyuiu.ShakhovDK.Sprint3.Task4.V20.Lib;
namespace Tyuiu.ShakhovDK.Sprint3.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 10.483;
            Assert.AreEqual(wait, res);
            
        }
    }
}