using System;
using DemoLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestDemoLibrary.Tests
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
