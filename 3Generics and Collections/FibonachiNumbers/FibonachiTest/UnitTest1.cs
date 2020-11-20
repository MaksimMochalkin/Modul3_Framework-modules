using FibonachiNumbers;
using NUnit.Framework;
using System;
using System.Numerics;

namespace FibonachiTest
{
    public class FibonachiTests
    {

        [Test]
        public void FibonachiNumbersTst()
        {
            var b = new BigInteger[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };
            CollectionAssert.AreEqual(b, Fibonachi.FibonachiNum(15));
           

        }

        [Test]
        public void FibonacciGeneratorTest2()
        {
            var b = new BigInteger[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946 };
            CollectionAssert.AreEqual(b, Fibonachi.FibonachiNum(22));
        }
    }
}