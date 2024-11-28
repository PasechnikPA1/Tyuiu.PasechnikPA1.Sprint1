using Tyuiu.PasechnikPA1.Sprint1.Task0.V20.Lib;
namespace Tyuiu.PasechnikPA1.Sprint1.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(13, res);
        }
    }
}
