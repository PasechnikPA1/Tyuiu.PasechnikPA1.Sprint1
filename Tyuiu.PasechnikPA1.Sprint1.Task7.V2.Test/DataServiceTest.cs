using Tyuiu.PasechnikPA1.Sprint1.Task7.V2.Lib;
namespace Tyuiu.PasechnikPA1.Sprint1.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;
            double z = 2.519;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);



        }
    }
}
