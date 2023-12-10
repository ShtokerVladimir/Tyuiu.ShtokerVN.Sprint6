using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShtokerVN.Sprint6.Task5.V22.Lib;

namespace Tyuiu.ShtokerVN.Sprint6.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void validLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutFileTask5V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
