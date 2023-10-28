using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint3.Task3.V27.Lib;

namespace Tyuiu.ShananinaVV.Sprint3.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();

            string value = "!bt, g567kid f!";

            int num = ds.ConvertStringToInt(value);
            int wait = 567;
            Assert.AreEqual(num, wait);
        }
    }
}
