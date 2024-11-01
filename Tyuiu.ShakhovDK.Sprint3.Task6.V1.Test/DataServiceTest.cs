using Tyuiu.ShakhovDK.Sprint3.Task6.V1.Lib;
namespace Tyuiu.ShakhovDK.Sprint3.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int s = 11, e = 17;
            int res = ds.GetSumTheDivisors(s, e);
            int wait = 151;
            Assert.AreEqual(wait, res);
        }
    }
}