using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShtokerVN.Sprint6.Task7.V29.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\geroin\source\repos\Tyuiu.ShtokerVN.Sprint6\Tyuiu.ShtokerVN.Sprint6.Task7.V29\bin\Debug\InPutFileTask7V29.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
