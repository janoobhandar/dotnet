﻿using NUnit.Framework;
using HelloWorld;

namespace HelloWorldNUnitTest
{    

    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.IsDataContainsKeyword("Hello Unit Tester", "Kello"));
        }
         [Test]
        public void TestMethod2()
        {
            Assert.IsTrue(Program.IsDataContainsKeyword("Hello Unit Tester", "Hello"));
        }
    }
}
