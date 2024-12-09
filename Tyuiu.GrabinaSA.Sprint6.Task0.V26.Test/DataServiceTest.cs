using Tyuiu.GrabinaSA.Sprint6.Task0.V26.Lib;
namespace Tyuiu.GrabinaSA.Sprint6.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 0.769;
            Assert.AreEqual(wait, res);
        }
    }
}
