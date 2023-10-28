using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint3.Task6.V13.Lib;

namespace Tyuiu.ShananinaVV.Sprint3.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 8;
            int stopValue = 17;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 117;

            Assert.AreEqual(wait, res);
        }
    }
}
