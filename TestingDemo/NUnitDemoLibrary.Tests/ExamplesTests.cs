using DemoLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemoLibrary.Tests
{
    [TestFixture]
    public class ExamplesTests
    {
        [Test]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("This is a valid file name.");

            Assert.True(actual.Length > 0);
        }

        [Test]
        public void ExampleLoadTextFile_InvalidNameShouldFail()
        {
            Assert.Throws<ArgumentException>(() => Examples.ExampleLoadTextFile(""));
        }
    }
}
