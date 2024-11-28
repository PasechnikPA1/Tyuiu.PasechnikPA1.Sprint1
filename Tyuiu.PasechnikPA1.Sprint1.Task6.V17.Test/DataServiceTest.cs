using Tyuiu.PasechnikPA1.Sprint1.Task6.V17.Lib;
namespace Tyuiu.PasechnikPA1.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "XXAXX";
            var res = ds.CheckPalindrome(x);
            Assert.AreEqual(res, true);
        }
    }
    
}
