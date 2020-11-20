using Microsoft.VisualStudio.TestTools.UnitTesting;
using Revers_String;
using System;
using System.Collections.Generic;
using System.Text;

namespace Revers_String.Tests
{
    [TestClass()]
    public class ReversAllStringTests
    {
        [TestMethod()]
        public void ReverseStringTest()
        {
            string actual = "The greatest victory is that which requires no battle";
            string expected = "battle no requires which that is victory greatest The";
            Assert.AreEqual(expected, actual.ReverseString());
        }
    }
}