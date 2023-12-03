using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint6.Task2.V6.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void validGetMassfunction()
        {
            DataService ds = new DataService();

            int startStep = -5;
            int stopStep = 5;
            int len = Math.Abs(startStep) + Math.Abs(stopStep) + 1;
            double[] array = new double[len];
            array[0] = 59.49;
            array[1] = 38.47;
            array[2] = -2.81;
            array[3] = -19.67;
            array[4] = -8.42;
            array[5] = 0.57;
            array[6] = -6.3;
            array[7] = -20.14;
            array[8] = -3.51;
            array[9] = 38.13;
            array[10] = 59.6;

            double[] clown = ds.GetMassFunction(startStep, stopStep);
            CollectionAssert.AreEqual(array, clown);
        }
    }
}
