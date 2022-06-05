using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using CIDemo;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World";
        [TestMethod]
        public void TestMethod1()
        {
           
               string actuall= CIDemo.Program.Message();
            Assert.AreEqual(Expected, actuall);
            
        }
    }
}
