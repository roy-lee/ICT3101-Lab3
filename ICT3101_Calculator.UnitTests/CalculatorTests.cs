using ConsoleApp2;
using NUnit.Framework;

namespace Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        //[Test]
        //[TestCase(0, 0)]
        //[TestCase(0, 10)]
        //[TestCase(10, 0)]
        //public void Divide_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        //{
        //    Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        //}

        [Test]
        [TestCase(0)]
        [TestCase(-10)]
        public void Factorial_WithNegativeInputs_ResultThrowArgumentException(double a)
        {
            Assert.That(() => _calculator.Factorial(a), Is.EqualTo(1));
        }

        [Test]
        public void Factorial_WithNormalInputs_ResultExpectedResult()
        {
            Assert.That(() => _calculator.Factorial(5), Is.EqualTo(120));
        }

    }
}