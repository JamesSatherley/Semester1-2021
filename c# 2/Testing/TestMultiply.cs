using assignment2;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class TestingMultiply
    {
        Calculator calc;

        [TestInitialize]
        public void TestStart()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestMultiplyPositiveReal()
        {
            double[] a = { 5, 0 };
            double[] b = { 5, 0 };
            Assert.AreEqual(calc.Multiply(a, b), new Complex(25, 0));
        }

        [TestMethod]
        public void TestMultiplyNegativeReal()
        {
            double[] a = { -5, 0 };
            double[] b = { -5, 0 };
            Assert.AreEqual(calc.Multiply(a, b), new Complex(25, 0)); // -0 technically but no such thing 
        }

        [TestMethod]
        public void TestMultiplyPositiveImaginary()
        {
            double[] a = { 0, 5 };
            double[] b = { 0, 5 };
            Assert.AreEqual(calc.Multiply(a, b), new Complex(-25, 0));
        }

        [TestMethod]
        public void TestMultiplyNegativeImaginary()
        {
            double[] a = { 0, -5 };
            double[] b = { 0, -5 };
            Assert.AreEqual(calc.Multiply(a, b), new Complex(-25, 0)); // -0 technically but no such thing 
        }

        [TestMethod]
        public void TestMultiplyBigNumber()
        {
            double[] a = { 1000000000, 0 };
            double[] b = { 2, 0 };
            Assert.AreEqual(calc.Multiply(a, b), new Complex(2000000000, 0));
        }

        [TestMethod]
        public void TestMultiplyEmpty()
        {
            double[] a = { 0, 0 };
            double[] b = { 0, 0 };
            Assert.AreEqual(calc.Multiply(a, b), new Complex(0, 0));
        }

        [TestCleanup]
        public void TestEnd()
        {
            calc = null;
        }
    }
}
