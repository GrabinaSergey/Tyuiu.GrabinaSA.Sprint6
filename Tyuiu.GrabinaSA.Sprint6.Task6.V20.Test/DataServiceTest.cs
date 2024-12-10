using Tyuiu.GrabinaSA.Sprint6.Task6.V20.Lib;
namespace Tyuiu.GrabinaSA.Sprint6.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\ASUS\source\repos\Tyuiu.NedospasovaAE.Sprint6\Tyuiu.NedospasovaAE.Sprint6.Task6.V20\bin\Debug\InPutFileTask6V20.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "dKOPBC IqjpIlKAaSCBuaQUU GPeEqZo FPsrQHsImzbTBckw NgAfitECn";
            Assert.AreEqual(wait, res);
        }
    }
}
