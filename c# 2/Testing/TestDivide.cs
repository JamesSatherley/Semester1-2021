using assignment2;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class TestingDivide
    {
        Calculator calc;

        [TestInitialize]
        public void TestStart()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestDividePositiveReal()
        {
            double[] a = { 5, 0 };
            double[] b = { 5, 0 };
            Assert.AreEqual(calc.Divide(a, b), new Complex(1, 0));
        }

        [TestMethod]
        public void TestDivideNegativeReal()
        {
            double[] a = { -5, 0 };
            double[] b = { -5, 0 };
            Assert.AreEqual(calc.Divide(a, b), new Complex(1, 0));
        }

        [TestMethod]
        public void TestDividePositiveImaginary()
        {
            double[] a = { 0, 5 };
            double[] b = { 0, 5 };
            Assert.AreEqual(calc.Divide(a, b), new Complex(1, 0));
        }

        [TestMethod]
        public void TestDivideNegativeImaginary()
        {
            double[] a = { 0, -10 };
            double[] b = { 0, -5 };
            Assert.AreEqual(calc.Divide(a, b), new Complex(2, 0)); // -0 technically but no such thing 
        }

        [TestMethod]
        public void TestDivideBigNumber()
        {
            double[] a = { 2000000000, 0 };
            double[] b = { 2, 0 };
            Assert.AreEqual(calc.Divide(a, b), new Complex(1000000000, 0));
        }

        [TestMethod]
        public void TestDivideEmpty()
        {
            double[] a = { 0, 0 };
            double[] b = { 0, 0 };
            Assert.AreEqual(calc.Divide(a, b), new Complex(0, 0));
        }

        [TestCleanup]
        public void TestEnd()
        {
            calc = null;
        }
    }
}
