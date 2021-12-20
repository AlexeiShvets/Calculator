using NUnit.Framework;
using Sh.Calculator;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        public void Addition_Digits4_EqualExpected()
        {
            double expected = 0.2468;
            double val = 0.1234;

            Assert.AreEqual(expected, Calculator.Addition(val, val, 4));
        }

        [TestCase(1, 1, 2)]
        [TestCase(-10000, 9999, -1)]
        [TestCase(10000, -50, 9950)]
        [TestCase(-50, -50, -100)]
        [TestCase(1000, 1000, 2000)]
        [TestCase(0.5, 0.5, 1)]
        [TestCase(0.1234, 0.1234, 0.247)]
        public void Addition_EqualExpected(double a, double b, double expected)
        {
            Assert.AreEqual(expected, Calculator.Addition(a, b));
        }

        [TestCase(1, 1, 0)]
        [TestCase(-10000, 9999, -19999)]
        [TestCase(10000, -50, 10050)]
        [TestCase(-50, -50, 0)]
        [TestCase(1000, 1000, 0)]
        [TestCase(0.5, 0.5, 0)]
        public void Subtraction_EqualExpected(double a, double b, double expected)
        {
            Assert.AreEqual(expected, Calculator.Subtraction(a, b));
        }

        [TestCase(1, 1, 1)]
        [TestCase(-10000, 9999, -99990000)]
        [TestCase(10000, -50, -500000)]
        [TestCase(-50, -50, 2500)]
        [TestCase(1000, 1000, 1000000)]
        [TestCase(0.5, 0.5, 0.25)]
        public void Multiplication_EqualExpected(double a, double b, double expected)
        {
            Assert.AreEqual(expected, Calculator.Multiplication(a, b));
        }

        [TestCase(1, 1, 1)]
        [TestCase(-10000, 9999, -1)]
        [TestCase(10000, -50, -200)]
        [TestCase(-50, -50, 1)]
        [TestCase(1000, 1000, 1)]
        [TestCase(0.5, 0.5, 1)]
        public void Division_EqualExpected(double a, double b, double expected)
        {
            Assert.AreEqual(expected, Calculator.Division(a, b));
        }
    }
}