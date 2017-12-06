using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using theapi.Controllers;
using theapi.Models;

namespace theapi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HelloController HC = new HelloController();
            string tv = HC.GetHello();
            Assert.AreEqual(tv, "Hello World");
        }
    }
}
