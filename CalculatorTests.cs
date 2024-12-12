using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            //
            int excpected = 5;

            //act
            int result = _calculator.Add(2, 3);

            //asssert
            Assert.Equals(excpected, result);
        }

        [Test]
        public void Subtract_ShouldReturnDifferenceOfTwoNumbers()
        {
            int result = _calculator.Subtract(5, 3);
            Assert.Equals(2, result);
        }
        [Test]
        public void AddBoundaryNumbers()
        {
            int Positive = int.MaxValue;
            //  int Negative = int.MinValue + 1;

            int resualtP = _calculator.Add(Positive, Positive);
            //int resualtN = _calculator.Add(int.MinValue + 1, 1);

            Assert.Equals(2 * Positive, resualtP);
            //Assert.Equals(Negative, resualtN);
        }
        [Test]
        public void SubstrackBoundaryNumbers()
        {
            int Positive = int.MaxValue;
            int Negative = int.MinValue;

            int resualtP = _calculator.Add(int.MaxValue - 1, 1);
            int resualtN = _calculator.Add(int.MinValue + 1, 1);

            Assert.Equals(Positive, resualtP);
            Assert.Equals(Negative, resualtN);
        }
    }
}
