using assignment2;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class TestingAdd
    {
        Calculator calc;

        [TestInitialize]
        public void TestStart()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestAddPositiveReal()
        {
            double[] a = { 5, 0 };
            double[] b = { 5, 0 };
            Assert.AreEqual(calc.Add(a, b), new Complex(10, 0));
        }

        [TestMethod]
        public void TestAddNegativeReal()
        {
            double[] a = { -5, 0 };
            double[] b = { -5, 0 };
            Assert.AreEqual(calc.Add(a, b), new Complex(-10, 0));
        }

        [TestMethod]
        public void TestAddPositiveImaginary()
        {
            double[] a = { 0, 5 };
            double[] b = { 0, 5 };
            Assert.AreEqual(calc.Add(a, b), new Complex(0, 10));
        }

        [TestMethod]
        public void TestAddNegativeImaginary()
        {
            double[] a = { 0, -5 };
            double[] b = { 0, -5 };
            Assert.AreEqual(calc.Add(a, b), new Complex(0, -10));
        }

        [TestMethod]
        public void TestAddBigNumber()
        {
            double[] a = { 1000000000, 0 };
            double[] b = { 1000000000, 0 };
            Assert.AreEqual(calc.Add(a, b), new Complex(2000000000, 0));
        }

        [TestMethod]
        public void TestAddEmpty()
        {
            double[] a = { 0, 0 };
            double[] b = { 0, 0 };
            Assert.AreEqual(calc.Add(a, b), new Complex(0, 0));
        }

        [TestCleanup]
        public void TestEnd()
        {
            calc = null;
        }
    }
}
