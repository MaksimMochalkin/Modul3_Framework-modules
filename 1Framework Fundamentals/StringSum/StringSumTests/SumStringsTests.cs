using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringSum;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringSum.Tests
{
    [TestClass()]
    public class SumStringsTests
    {
        [TestMethod()]
        public void MultiplayAnyStringNumberTest()
        {
            string first = "10000000000";
            string second = "10000000000";
            string actual = SumStrings.SumAnyStringNumber(first, second);
            string expected = "20000000000";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]

        public void MultiplayAnyStringNumberTest2()
        {
            string first = "100000000000000000000";
            string second = "100000000000000000000";
            string actual = SumStrings.SumAnyStringNumber(first, second);
            string expected = "200000000000000000000";
            Assert.AreEqual(expected, actual);
        }

    }
}