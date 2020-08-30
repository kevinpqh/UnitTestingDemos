using DemoLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitMsTestDemo
{
    [TestClass]
    public class ExamplesTests
    {
        [TestMethod]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("This is a valid file name.");

            Assert.IsTrue(actual.Length > 0);
        }

        [TestMethod]
        public void ExampleLoadTextFile_InvalidNameShouldFail()
        {
            Assert.ThrowsException<ArgumentException>(() => Examples.ExampleLoadTextFile(""));
        }
    }
}
