using Tyuiu.PasechnikPA1.Sprint1.Task1.V20.Lib;
namespace Tyuiu.PasechnikPA1.Sprint1.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(11, res);
        }
    }
}
