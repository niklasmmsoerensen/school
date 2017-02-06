using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calculator.UnitTest
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private calculator _uut;
        [SetUp]
        public void Setup()
        {
            _uut = new calculator();
        }

        [Test]
        public void AddNumbers_TwoPositiveNumbers_PositiveResult()
        {
            Assert.That(_uut.add(2, 2), Is.EqualTo(4));
        }

        [Test]
        public void AddNumbers_OneNegativeOnePositive_NegativeResult()
        {
            Assert.That(_uut.add(-3, 2), Is.EqualTo(-1));
        }
        [Test]
        public void AddNumbers_TwoNegativeNumbers_NegativeResult()
        {
            Assert.That(_uut.add(-3, -3), Is.EqualTo(-6));
        }

        [Test]
        public void SubstractNumbers_TwoPositiveNumbers_NegativeResult()
        {
            Assert.That(_uut.substract(1, 5), Is.EqualTo(-4));
        }
        [Test]
        public void SubstractNumbers_TwoNegativeNumbers_NegativeResult()
        {
            Assert.That(_uut.substract(-2, -2), Is.EqualTo(0));
        }
        [Test]
        public void SubstractNumbers_OneBigNumberSubstractedWithSmall_PositiveResult()
        {
            Assert.That(_uut.substract(10, 5), Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void Multiply_TwoPositiveNumbers_PositiveResult()
        {
            Assert.That(_uut.multiply(5,5), Is.GreaterThanOrEqualTo(0));
        }
        [Test]
        public void Multiply_OnePositiveOneNegative_NegativeResult()
        {
            Assert.That(_uut.multiply(5, -5), Is.LessThanOrEqualTo(0));
        }
        [Test]
        public void Multiply_OnePositiveOneNegative_PositiveResult()
        {
            Assert.That(_uut.multiply(-5, -5), Is.GreaterThanOrEqualTo(0));
        }
        [Test]
        public void Power_TwoPositiveNumbers_ResultIsAccurate()
        {
            Assert.That(_uut.power(2, 2), Is.EqualTo(4));
        }
        [Test]
        public void Power_NegativePower_ResultIsAccurate()
        {
            Assert.That(_uut.power(2, -2), Is.EqualTo(0.25));
        }
        [Test]
        public void Power_TwoNegativeNumbers_ResultIsAccurate()
        {
            Assert.That(_uut.power(-2, -2), Is.EqualTo(0.25));
        }

        [TestCase(2, 2, 4)]
        [TestCase(1, 2, 1)]
        public void Power_ExponentialVariant_ResultIsAccurate(double x, double exp, double result)
        {
            Assert.That(_uut.power(x, exp), Is.EqualTo(result));
        }
    }
}
