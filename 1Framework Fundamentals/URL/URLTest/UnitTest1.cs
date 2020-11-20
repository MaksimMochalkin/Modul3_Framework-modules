using NUnit.Framework;
using System;
using System.Text;
using URL;


namespace URLTest
{
    public class Tests
    {
       
        [Test]
        public void AddOrChangeUrlParameterTest()
        {
            URLAdd c = new URLAdd();
            string url = "www.example.com";
            string keyValue = "key=value";
            string expected = "www.example.comkey=value";
            string actual = c.AddOrChangeUrlParameter(url, keyValue);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddOrChangeUrlParameterTestRemove()
        {
            URLAdd c = new URLAdd();
            string url = "www.example.comkey=value";
            string keyValue = "key=value";
            string expected = "www.example.com";
            string actual = c.AddOrChangeUrlParameter(url, keyValue);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddOrChangeUrlParameterTestNullAppend()
        {
            URLAdd c = new URLAdd();
            string url = "www.example.comkey=value";
            string keyValue = "key=value32";
            string expected = "www.example.comkey=valuekey=value32";
            string actual = c.AddOrChangeUrlParameter(url, keyValue);
            Assert.AreEqual(expected, actual);
        }
    }
}