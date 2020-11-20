using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchPart1;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchPart1.Tests
{
    [TestClass()]
    public class BinarySTests
    {
        
        [TestMethod()]
        public void BinarySearchTest()
        {
            var list = new List<char> { 'a', 'n', 'v', 'x', 'z' };
            var ch = 'x';
            var expected = 3;
            var actual = BinaryS.BinarySearch(list, ch);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void BinarySearchTest1()
        {
            var list = new List<int> { int.MinValue, -100, 0, 44, 45, 100, 200 };
            var ch = 45;
            var expected = 4;
            var actual = BinaryS.BinarySearch(list, ch);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinarySearchTest2()
        {
            var list = new List<string> { "A", "C", "D", "F", "x", "Y", "Z" };
            var ch = "D";
            var expected = 2;
            var actual = BinaryS.BinarySearch(list, ch);
            Assert.AreEqual(expected, actual);
        }
    }
}