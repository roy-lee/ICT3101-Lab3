using ConsoleApp2;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private Calculator _calculator;
        // Context Injection for SpecFlow
        private UsingCalculatorDivisionsSteps(Calculator calc)
        {
            this._calculator = calc;
        }
        public double _result;

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = _calculator.Divide(p0, p1);
        }
        
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        //[Then(@"the division result should be ""(.*)""")]
        //public void ThenTheDivisionResultShouldBe(int p0)
        //{
        //    Assert.That(_result, Is.EqualTo(p0));

        //}

        [Then(@"the division result should be Infinity on the screen")]
        public void ThenTheDivisionResultShouldBeInfinityOnTheScreen()
        {
            double result = double.PositiveInfinity;
            Assert.That(_result, Is.EqualTo(result));

        }
    }
}
