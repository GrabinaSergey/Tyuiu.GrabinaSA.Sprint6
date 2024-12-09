using Tyuiu.GrabinaSA.Sprint6.Task2.V9.Lib;
namespace Tyuiu.GrabinaSA.Sprint6.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] wait;
            wait = new double[len];

            wait[0] = 4.34;
            wait[1] = 4.16;
            wait[2] = 3.71;
            wait[3] = 3.27;
            wait[4] = 2.93;
            wait[5] = 2.50;
            wait[6] = 0.71;
            wait[7] = -47.61;
            wait[8] = 55.15;
            wait[9] = 45.17;
            wait[10] = 14.97;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
