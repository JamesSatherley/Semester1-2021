using assignment2;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class TestSqrt
    {
        Calculator calc;

        [TestInitialize]
        public void TestStart()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestSqrtPositiveReal()
        {
            double[] a = { 25, 0 };
            Assert.AreEqual(calc.Sqrt(a), new Complex(5, 0));
        }

        [TestMethod]
        public void TestSqrtNegativeReal()
        {
            double[] a = { -25, 0 };
            Assert.AreEqual(calc.Sqrt(a), new Complex(0, 5));
        }

        [TestMethod]
        public void TestSqrtPositiveImaginary()
        {
            double[] a = { 0, 8 };
            Assert.AreEqual(calc.Sqrt(a), new Complex(2, 2));
        }

        [TestMethod]
        public void TestSqrtNegativeImaginary()
        {
            double[] a = { 0, -8 };
            Assert.AreEqual(calc.Sqrt(a), new Complex(2, -2));
        }

        [TestMethod]
        public void TestSqrtBigNumber()
        {
            double[] a = { 0, 1000000000 };
            Assert.AreEqual(calc.Sqrt(a), new Complex(22360.679774997898, 22360.679774997898));
        }

        [TestMethod]
        public void TestSqrtEmpty()
        {
            double[] a = { 0, 0 };
            Assert.AreEqual(calc.Sqrt(a), new Complex(0, 0));
        }

        [TestCleanup]
        public void TestEnd()
        {
            calc = null;
        }
    }
}
