using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordCounter.Tests
{
    [TestClass()]
    public class CounterTests
    {
        [TestMethod()]
        public void CounterTest()
        {
            var c = new Counter(@"C:\Users\User\source\repos\Modul3_Framework-modules\3Generics and Collections\WordCounter\WordCounter\Test.txt");


        }

        [TestMethod()]
        public void CounterTest1()
        {

        }
    }
}