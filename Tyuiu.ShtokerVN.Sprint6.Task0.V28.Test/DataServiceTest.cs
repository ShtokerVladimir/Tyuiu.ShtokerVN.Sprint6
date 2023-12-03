using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint6.Task0.V28.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double zxc = ds.Calculate(3);
            double wait = 169.89;
            Assert.AreEqual(wait, zxc);
        }
    }
}
