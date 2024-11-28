using Tyuiu.PasechnikPA1.Sprint1.Task2.V17.Lib;
namespace Tyuiu.PasechnikPA1.Sprint1.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 100;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(1, res);
        }
    }
}
