using assignment2;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class TestingSubtract
    {
        Calculator calc;

        [TestInitialize]
        public void TestStart()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestSubtractPositiveReal()
        {
            double[] a = { 5, 0 };
            double[] b = { 5, 0 };
            Assert.AreEqual(calc.Subtract(a, b), new Complex(0, 0));
        }

        [TestMethod]
        public void TestSubtractNegativeReal()
        {
            double[] a = { -5, 0 };
            double[] b = { -5, 0 };
            Assert.AreEqual(calc.Subtract(a, b), new Complex(0, 0));
        }

        [TestMethod]
        public void TestSubtractPositiveImaginary()
        {
            double[] a = { 0, 5 };
            double[] b = { 0, 5 };
            Assert.AreEqual(calc.Subtract(a, b), new Complex(0, 0));
        }

        [TestMethod]
        public void TestSubtractNegativeImaginary()
        {
            double[] a = { 0, 5 };
            double[] b = { 0, 5 };
            Assert.AreEqual(calc.Subtract(a, b), new Complex(0, 0));
        }

        [TestMethod]
        public void TestSubtractNegativeBigNumber()
        {
            double[] a = { 1000000000, 0 };
            double[] b = { 1000000000, 0 };
            Assert.AreEqual(calc.Subtract(a, b), new Complex(0, 0));
        }

        [TestMethod]
        public void TestSubtractNegativeEmpty()
        {
            double[] a = { 0, 0 };
            double[] b = { 0, 0 };
            Assert.AreEqual(calc.Subtract(a, b), new Complex(0, 0));
        }

        [TestCleanup]
        public void TestEnd()
        {
            calc = null;
        }
    }
}
