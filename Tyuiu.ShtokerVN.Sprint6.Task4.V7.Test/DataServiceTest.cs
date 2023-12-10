using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShtokerVN.Sprint6.Task4.V7.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] Array;
            Array = new double[len];

            Array[0] = 15.19;
            Array[1] = 11.67;
            Array[2] = 9.00;
            Array[3] = 0.00;
            Array[4] = 4.08;
            Array[5] = 1.50;
            Array[6] = -2.28;
            Array[7] = -6.52;
            Array[8] = -10.19;
            Array[9] = -12.76;
            Array[10] = -14.68;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(Array, res);
        }
    
        [TestMethod]
        public void ValidSaveText()
        {
            string path = @"C:\Users\geroin\source\repos\Tyuiu.ShtokerVN.Sprint6\Tyuiu.ShtokerVN.Sprint6.Task4.V7\bin\Debug\OutPutFileTask4V7.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
