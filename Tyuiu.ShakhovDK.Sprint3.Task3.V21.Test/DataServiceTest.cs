using Tyuiu.ShakhovDK.Sprint3.Task3.V21.Lib;
namespace Tyuiu.ShakhovDK.Sprint3.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "f3g5ht g4j 34kg4";
            char item = 'e';
            string wait = "fegeht gej eekge";
            string res = ds.ReplaceNumOnChar(str, item);
            Assert.AreEqual(wait, res);
        }
    }
}