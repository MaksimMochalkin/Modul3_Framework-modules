using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate.Tests
{
    [TestClass()]
    public class PolishCalculateTests
    {
        [TestMethod()]
        public void CalaculateTest()
        {
            var str = "5 * ((1 * 2) * 4) - 3";
            var expected = 14;
            var actual = PolishCalculate.Calaculate(str);
            Assert.AreEqual(expected, actual);
        }
    }
}