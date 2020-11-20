using NUnit.Framework;
using System;

namespace GCDMethodsTest
{
    public class GCDMethodsTest1
    {
        [TestCase(-55, 11, 110, ExpectedResult = 11)]
        [TestCase(10, 20, 40, 50, 100, ExpectedResult = 10)]
        [TestCase(27, 0, 54, ExpectedResult = 27)]
        [TestCase(150, 450, 900, ExpectedResult = 150)]
        public int EclidGCDTest(params int[] array) => GCDMethods.Methods.EuclidGCD(array);

        [TestCase(null)]
        [TestCase(new int[0])]
        public void Euclid_AcceptsEmptyArray_ThrowsExteption(params int[] array) => Assert.Throws<ArgumentNullException>(()
                                                                                 => GCDMethods.Methods.EuclidGCD(array));

        [TestCase(-55, 11, 110, ExpectedResult = 11)]
        [TestCase(10, 20, 40, 50, 100, ExpectedResult = 10)]
        [TestCase(27, 0, 54, ExpectedResult = 27)]
        [TestCase(150, 450, 900, ExpectedResult = 150)]
        public int SteinGCDTest(params int[] array) => GCDMethods.Methods.SteinGCD(array);

        [TestCase(null)]
        [TestCase(new int[0])]
        public void Stein_AcceptsEmptyArray_ThrowsExteption(params int[] array) => Assert.Throws<ArgumentNullException>(()
                                                                                => GCDMethods.Methods.SteinGCD(array));

    }
}