using DemoLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMsTestDemo
{
    [TestClass]
    public class CalculatorTests
    {

        [DataTestMethod]
        [DataRow(4, 3, 7)]
        [DataRow(21, 5.25, 26.25)]
        [DataRow(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(8, 4, 2)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
