using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarsFactory;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ICar c = new Mercedes500();
            Assert.AreEqual(c.CurrenEngine().HP(), 300);
        }
    }
}
