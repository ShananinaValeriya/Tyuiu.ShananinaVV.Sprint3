using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint3.Task4.V2.Lib;

namespace Tyuiu.ShananinaVV.Sprint3.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 0.104;
            Assert.AreEqual(wait, res);
        }
    }
}
