using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint3.Task7.V4.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint3.Task7.V4.Test
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

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -22.10;
            valueWaitArray[1] = -3.94;
            valueWaitArray[2] = -6;
            valueWaitArray[3] = -9.81;
            valueWaitArray[4] = 3.40;
            valueWaitArray[5] = 3.00;
            valueWaitArray[6] = 12.81;
            valueWaitArray[7] = -25.03;
            valueWaitArray[8] = -12.12;
            valueWaitArray[9] = -20.42;
            valueWaitArray[10] = 58.41;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, valueWaitArray);
        }
    }
}
