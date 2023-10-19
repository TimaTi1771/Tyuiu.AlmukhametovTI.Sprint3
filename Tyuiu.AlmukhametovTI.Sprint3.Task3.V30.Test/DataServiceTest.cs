using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint3.Task3.V30.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint3.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCoun()
        {
            DataService ds = new DataService();

            string str = "fyyklbtyn ygrc vfyyyyh";
            char chr = 'y';
            int res = ds.GetMaxCharCount(str, chr);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
