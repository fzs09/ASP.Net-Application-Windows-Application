using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int Fnum = 10;
            int Snum = 20;
            int expected = 30;
            CalculatorOp ob = new CalculatorOp();
            //act
            int actual = ob.Add(Fnum, Snum);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            int Fnum = 10;
            int Snum = 20;
            int expected = 200;
            CalculatorOp ob = new CalculatorOp();
            //act
            int actual = ob.Mul(Fnum, Snum);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
