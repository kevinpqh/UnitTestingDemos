using DemoLibrary;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(4, 3, 7)]
        [TestCase(21, 5.25, 26.25)]
        [TestCase(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 4, 2)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
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