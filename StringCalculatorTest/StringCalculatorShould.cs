using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringCalculatorTest
{
    [TestClass]
    public class StringCalculatorShould
    {
        [TestMethod]
        public void Return_0_when_Receives_Empty()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Return_Number_when_Receives_That_Number()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Return_Sum_When_Receives_Two_Numbers()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Return_Sum_When_Receives_Any_Amount_of_Numbers()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2,3,4");
            Assert.AreEqual(10, result);
        }
    }
}
