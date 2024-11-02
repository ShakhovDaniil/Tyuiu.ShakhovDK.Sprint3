using Tyuiu.ShakhovDK.Sprint3.Task7.V8.Lib;
namespace Tyuiu.ShakhovDK.Sprint3.Task7.V8.Test
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
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -8.76;
            valueWaitArray[1] = -7.90;
            valueWaitArray[2] = -7.13;
            valueWaitArray[3] = -5.33;
            valueWaitArray[4] = -2.30;
            valueWaitArray[5] = 1.00;
            valueWaitArray[6] = 4.38;
            valueWaitArray[7] = 0.00;
            valueWaitArray[8] = 4.15;
            valueWaitArray[9] = 6.59;
            valueWaitArray[10] = 9.32;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}