using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint3.Task1.V30.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 12;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 9.63;
            Assert.AreEqual(wait, res);

        }
    }
}
