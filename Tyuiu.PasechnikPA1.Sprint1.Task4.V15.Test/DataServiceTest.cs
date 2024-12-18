﻿using Tyuiu.PasechnikPA1.Sprint1.Task4.V15.Lib;
namespace Tyuiu.PasechnikPA1.Sprint1.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = Math.Round(2420.5727, 3);
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}
