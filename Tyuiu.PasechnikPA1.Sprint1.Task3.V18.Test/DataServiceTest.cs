using Tyuiu.PasechnikPA1.Sprint1.Task3.V18.Lib;
namespace Tyuiu.PasechnikPA1.Sprint1.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2;
            double b = 4;
            double c = 4;
            double wait = 0.5;
            var res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}
