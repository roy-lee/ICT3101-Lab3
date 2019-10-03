using ConsoleApp2;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {
        private Calculator _calculator;
        // Context Injection for SpecFlow
        private UsingCalculatorAvailabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        public double _result;

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double p0, double p1)
        {
            _result = _calculator.MTBF(p0, p1);
        }

        [Then(@"the mtbf result should be ""(.*)""")]
        public void ThenTheMtbfResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo((p0)));
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {
            _result = _calculator.Availability(p0, p1);
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo((p0)));
        }

    }
}
