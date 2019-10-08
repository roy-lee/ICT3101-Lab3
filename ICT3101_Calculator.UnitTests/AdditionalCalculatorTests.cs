using ConsoleApp2;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator.UnitTests
{
    class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
                fr.Read("../../../../ConsoleApp2/MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
            _calculator = new Calculator();
        }

        [Test]
        [TestCase(1)]
        public void MagicNumber_WithEachLine_ResultExpectedResult(double choice)
        {
            Assert.That(() => _calculator.GenMagicNum(choice, _mockFileReader.Object), Is.EqualTo(84));
        }

    }
}
