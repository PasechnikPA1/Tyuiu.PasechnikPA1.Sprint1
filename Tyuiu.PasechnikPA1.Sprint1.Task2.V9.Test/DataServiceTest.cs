using Tyuiu.PasechnikPA1.Sprint1.Task2.V9.Lib;
namespace Tyuiu.PasechnikPA1.Sprint1.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateVolumeCircle(x);
            Assert.AreEqual(33.493333333333333, res);
        }
    }
}
